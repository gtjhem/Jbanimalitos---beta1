using System;

using System.Text;
using System.Runtime.InteropServices;

namespace Jbanimalitosv2
{
    public class TicketCS
    {
        /// <summary>
        /// Medida de Los Caracteres de Impresion Por Linea Desde La Impresora Reseptora (IMPRESORA DE TICKETs)
        /// Se Puede Cambiar Valor De Maximos por Linea Segun Se Desea o Criterio Para Fines Concretos
        /// </summary>
        /// 

        StringBuilder lineas = new StringBuilder();
        int MaxCtresXLinea = 30, Cortar;

        /// <summary>
        /// Para Dibujar las Lineas De La Impresion Con el Caracter de Impresion Deseable Segun Gustos-Pre-Encabezado
        /// </summary>
        /// <returns></returns>

        public string LineasPunteadas()
        {
            string LineaPunteada = "";
            
            for (int i = 0; i < MaxCtresXLinea; i++)
            {
                LineaPunteada += "-";//Es El Caracter Divisor o Los Guiones se Puede Cambiar(#$%&-_\) Para Personalizar
            }
            return lineas.AppendLine(LineaPunteada).ToString();
            ;
        }

        /// <summary>
        /// Para Dibujar Las Lineas De iMpresion COn el Caracter de Impresion Deseable Segun Gustos-Pre(Sub)Encabezado
        /// </summary>
        /// <returns></returns>

        public string LineasAsteriscos()
        {
            string LineaAsterisco = "";
            for (int i = 0; i < MaxCtresXLinea; i++)
            {
                LineaAsterisco += "*";
            }
            return lineas.AppendLine(LineaAsterisco).ToString();
        }

        /// <summary>
        /// Para Dibujar Las Lineas De iMpresion COn el Caracter de Impresion Deseable Segun Gustos-Despues del Encabezado de Articulos
        /// </summary>
        /// <returns></returns>

        public string LineasIgualdad()
        {
            string LineaIgual = "";
            for (int i = 0; i < MaxCtresXLinea; i++)
            {
                LineaIgual += "=";
            }
            return lineas.AppendLine(LineaIgual).ToString();
        }

        /// <summary>
        /// Cabezera del Ticket Para Agregar Los Nombres de Los Articulos (Solo Son el Encabezado de la Los Intems En las Ventas)
        /// De Acuerto a Cada Caracteres el maximo de caractes por linea se define arriba que es 42 esta cantidad en personalizable
        /// de aceurdo a las necesidades de cada Tipo de impresion
        /// </summary>

        public void CabezeraVenta()
        {
            lineas.AppendLine("ARTICULO            |CANT|P-UNIT|IMPORTE");//
        }

        /// <summary>
        /// Utiliza el texto de las cabezeras para agregar el texto alineado a la ixquierda de los alineados
        /// </summary>
        /// <param name="texto"></param>

        public void TextoAlaIzquierda(string texto)
        {
            if (texto.Length > MaxCtresXLinea)
            {
                int ValorFinal = 0;
                for (int valortexto = texto.Length; valortexto > MaxCtresXLinea; valortexto -= MaxCtresXLinea)
                {
                    lineas.AppendLine(texto.Substring(ValorFinal, MaxCtresXLinea));
                    ValorFinal += MaxCtresXLinea;
                }
                lineas.AppendLine(texto.Substring(ValorFinal, texto.Length - ValorFinal));
            }
            else
            {
                lineas.AppendLine(texto);
            }
        }

        public void TextoAlaDerecha(string texto)
        {
            if (texto.Length < MaxCtresXLinea)
            {

                int ValorFinal = 0;
                for (int ValorTexto = texto.Length; ValorTexto > MaxCtresXLinea; ValorTexto -= MaxCtresXLinea)
                {
                    lineas.AppendLine(texto.Substring(ValorFinal, MaxCtresXLinea));
                    ValorFinal += MaxCtresXLinea;
                }

                string rellenos = "";
                for (int i = 0; i < (MaxCtresXLinea - texto.Substring(ValorFinal, texto.Length - ValorFinal).Length); i++)
                {
                    rellenos += " ";
                }
                lineas.AppendLine(rellenos + texto.Substring(ValorFinal, texto.Length - ValorFinal));
            }
            else
            {
                string rellenos = "";
                for (int i = 0; i < (MaxCtresXLinea - texto.Length); i++)
                {
                    rellenos += " ";
                }
                lineas.AppendLine(rellenos + texto);
            }
        }

        public void TextoCentrado(string texto)
        {
            if (texto.Length > MaxCtresXLinea)
            {
                int ValorFinal = 0;
                for (int ValorTexto = texto.Length; ValorTexto > MaxCtresXLinea; ValorTexto -= MaxCtresXLinea)
                {
                    lineas.AppendLine(texto.Substring(ValorFinal, MaxCtresXLinea));
                    ValorFinal += MaxCtresXLinea;
                }

                string rellenos = "";
                int Centro = (MaxCtresXLinea - texto.Substring(ValorFinal, texto.Length - ValorFinal).Length) / 2;

                for (int i = 0; i < Centro; i++)
                {
                    rellenos += " ";
                }

                lineas.AppendLine(rellenos + texto.Substring(ValorFinal, texto.Length - ValorFinal));
            }
            else
            {
                string rellenos = "";
                int Centro = (MaxCtresXLinea - texto.Length) / 2;
                for (int i = 0; i < Centro; i++)
                {
                    rellenos += " ";
                }
                lineas.AppendLine(rellenos + texto);
            }
        }

        public void TextoExtremos(string TextoIzquierda, string TextoDerecha)
        {
            string TxtLeft, TxtRight, TxtComplete = "", rellenos = "";

            if (TextoIzquierda.Length > 18)
            {
                Cortar = TextoIzquierda.Length - 18;
                TxtLeft = TextoIzquierda.Remove(18, Cortar);
            }
            else
            {
                TxtLeft = TextoIzquierda;
            }
            TxtComplete = TextoIzquierda;

            if (TextoDerecha.Length > 20)
            {
                Cortar = TextoDerecha.Length - 20;
                TxtRight = TextoDerecha.Remove(20, Cortar);
            }
            else
            {
                TxtRight = TextoDerecha;
            }
            int ValorEspacios = MaxCtresXLinea - (TxtLeft.Length + TxtRight.Length);
            for (int i = 0; i < ValorEspacios; i++)
            {
                rellenos += " ";
            }
            TxtComplete += rellenos + TxtRight;
            lineas.AppendLine(TxtComplete);
        }

        public void AgregarSubTotales(string texto, decimal total)
        {
            string resumen, valor, TxtComplete, rellenos = "";

            if (texto.Length > 25)
            {
                Cortar = texto.Length - 25;
                resumen = texto.Remove(25, Cortar);
            }
            else
            {
                resumen = texto;
            }
            TxtComplete = resumen;
            valor = total.ToString("#,#.00");

            int ValorEspacios = MaxCtresXLinea - (resumen.Length + valor.Length);

            for (int i = 0; i < ValorEspacios; i++)
            {
                rellenos += " ";
            }
            TxtComplete += rellenos + valor;
            lineas.AppendLine(TxtComplete);
        }

        public void AgregarArticulos(string articulo, int cant, decimal punit, decimal importe)
        {
            if (cant.ToString().Length <= 5 && punit.ToString().Length <= 7 && importe.ToString().Length <= 8)
            {
                string items = "", rellenos = "";
                bool limite = false;
                int ValorEspacios = 0;

                if (articulo.Length > 20)
                {
                    ValorEspacios = (5 - cant.ToString().Length);
                    rellenos = "";
                    for (int i = 0; i < ValorEspacios; i++)
                    {
                        rellenos += " ";
                    }
                    items += rellenos + cant.ToString();

                    ValorEspacios = (7 - punit.ToString().Length);
                    rellenos = "";
                    for (int i = 0; i < ValorEspacios; i++)
                    {
                        rellenos += " ";
                    }
                    items += rellenos + punit.ToString();

                    ValorEspacios = (8 - importe.ToString().Length);
                    rellenos = "";
                    for (int i = 0; i < ValorEspacios; i++)
                    {
                        rellenos += " ";

                    }
                    items += rellenos + importe.ToString();

                    int ValorActual = 0;

                    for (int ValorTexto = articulo.Length; ValorTexto > 20; ValorTexto -= 20)
                    {
                        if (limite == false)
                        {
                            lineas.AppendLine(articulo.Substring(ValorActual, 20) + items);
                            limite = true;
                        }
                        else
                            lineas.AppendLine(articulo.Substring(ValorActual, 20));
                        ValorActual += 20;
                    }
                    lineas.AppendLine(articulo.Substring(ValorActual, articulo.Length - ValorActual));
                }
                else
                {
                    for (int i = 0; i < (20 - articulo.Length); i++)
                    {
                        rellenos += " ";
                    }
                    items = articulo + rellenos;

                    ValorEspacios = (5 - cant.ToString().Length);
                    rellenos = "";

                    for (int i = 0; i < ValorEspacios; i++)
                    {
                        rellenos += " ";
                    }
                    items += ValorEspacios + cant.ToString();

                    ValorEspacios = (7 - punit.ToString().Length);
                    rellenos = "";
                    for (int i = 0; i < ValorEspacios; i++)
                    {
                        rellenos += " ";
                    }
                    items += ValorEspacios + punit.ToString();

                    ValorEspacios = (7 - importe.ToString().Length);
                    rellenos = "";
                    for (int i = 0; i < ValorEspacios; i++)
                    {
                        rellenos += " ";
                    }
                    items += ValorEspacios + importe.ToString();

                    lineas.AppendLine(items);
                }
            }
            else
            {
                lineas.AppendLine("Los Valores Ingresados Para Esta Fila");
                lineas.AppendLine("Han Superado el Numero de Columnas De Esta");
                throw new Exception("Los Valores Ingresados Para Algunas Filas Del Ticket \nSuperan Las Columnas Soportadas Por Este.");
            }
        }

        //este el comando que le envio despues de imprimir el ticket por otro lado es para mi caos tengo una ticketera (POS-D)GP-7546
        public void CortaCinta()
        {

            lineas.AppendLine("\x1B" + "d" + "\x05");
            lineas.AppendLine("\x1B" + "m");
        }

        public void OpenBoxCash()
        {
            lineas.AppendLine("\x1B" + "p" + "\x00" + "\x0F" + "\x96");
        }

        public void PrintTicket(string printer)
        {
            RawPrinterHelper.SendStringToPrinter(printer, lineas.ToString());
            lineas.Clear();
        }
    }
    public class RawPrinterHelper
    {
        // Structure and API declarions:
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public class DOCINFOA
        {
            [MarshalAs(UnmanagedType.LPStr)]
            public string pDocName;
            [MarshalAs(UnmanagedType.LPStr)]
            public string pOutputFile;
            [MarshalAs(UnmanagedType.LPStr)]
            public string pDataType;
        }

        [DllImport("winspool.Drv", EntryPoint = "OpenPrinterA", SetLastError = true, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool OpenPrinter([MarshalAs(UnmanagedType.LPStr)] string szPrinter, out IntPtr hPrinter, IntPtr pd);

        [DllImport("winspool.Drv", EntryPoint = "ClosePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool ClosePrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint = "StartDocPrinterA", SetLastError = true, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool StartDocPrinter(IntPtr hPrinter, Int32 level, [In, MarshalAs(UnmanagedType.LPStruct)] DOCINFOA di);

        [DllImport("winspool.Drv", EntryPoint = "EndDocPrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool EndDocPrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint = "StartPagePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool StartPagePrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint = "EndPagePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool EndPagePrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint = "WritePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool WritePrinter(IntPtr hPrinter, IntPtr pBytes, Int32 dwCount, out Int32 dwWritten);

        // SendBytesToPrinter()
        // When the function is given a printer name and an unmanaged array
        // of bytes, the function sends those bytes to the print queue.
        // Returns true on success, false on failure.
        public static bool SendBytesToPrinter(string szPrinterName, IntPtr pBytes, Int32 dwCount)
        {
            Int32 dwError = 0, dwWritten = 0;
            IntPtr hPrinter = new IntPtr(0);
            DOCINFOA di = new DOCINFOA();
            bool bSuccess = false; // Assume failure unless you specifically succeed.
            
           
            di.pDocName = "Ticket De Venta C#";
            di.pDataType = "RAW";
            
            
            

            // Open the printer.
            if (OpenPrinter(szPrinterName.Normalize(), out hPrinter, IntPtr.Zero))
            {
                // Start a document.
                if (StartDocPrinter(hPrinter, 1, di))
                {
                    // Start a page.
                    if (StartPagePrinter(hPrinter))
                    {
                        // Write your bytes.
                        bSuccess = WritePrinter(hPrinter, pBytes, dwCount, out dwWritten);
                        EndPagePrinter(hPrinter);
                    }
                    EndDocPrinter(hPrinter);
                }
                ClosePrinter(hPrinter);
            }
            // If you did not succeed, GetLastError may give more information
            // about why not.
            if (bSuccess == false)
            {
                dwError = Marshal.GetLastWin32Error();
            }
            return bSuccess;
        }

        public static bool SendStringToPrinter(string szPrinterName, string szString)
        {
            IntPtr pBytes;
            Int32 dwCount;
            // How many characters are in the string?
            dwCount = szString.Length;
            // Assume that the printer is expecting ANSI text, and then convert
            // the string to ANSI text.
            pBytes = Marshal.StringToCoTaskMemAnsi(szString);
            // Send the converted ANSI string to the printer.
            SendBytesToPrinter(szPrinterName, pBytes, dwCount);
            Marshal.FreeCoTaskMem(pBytes);
            return true;
        }
    }
}
