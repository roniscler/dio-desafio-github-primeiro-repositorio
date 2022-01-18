using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;
using System.ServiceProcess;

namespace Apresentacao
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Process aProcess = Process.GetCurrentProcess();
            string aProcName = aProcess.ProcessName;
            if (Process.GetProcessesByName(aProcName).Length > 1)
            {
                MessageBox.Show("O sistema já está em execução!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string myServiceName = "MSSQL$SQLEXPRESS"; //service name of SQL Server Express
            string status; //service status (For example, Running or Stopped)

            //Console.WriteLine("Serviço: " + myServiceName);

            //display service status: For example, Running, Stopped, or Paused
            ServiceController mySC = new ServiceController(myServiceName);

            try
            {
                status = mySC.Status.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Serviço do SQL Server Express não disponível. Verifique se ele está instalado. [exception=" + ex.Message + "]");
                Console.ReadLine();

                return;

            }

            //display service status: For example, Running, Stopped, or Paused
            //Console.WriteLine("Status do Serviço : " + status);

            //if service is Stopped or StopPending, you can run it with the following code.
            if (mySC.Status.Equals(ServiceControllerStatus.Stopped) | mySC.Status.Equals(ServiceControllerStatus.StopPending))
            {
                try
                {
                    //Console.WriteLine("Iniciando o SQL Server Express...");
                    mySC.Start();
                    mySC.WaitForStatus(ServiceControllerStatus.Running);
                    //Console.WriteLine("SQL Server Express funcionando" + mySC.Status.ToString());

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao iniciar o serviço do SQL Server Express: " + ex.Message, "Erro SQL Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
            else if  (mySC.Status.Equals(ServiceControllerStatus.Paused))
            {
                try
                {
                    //Console.WriteLine("Iniciando o SQL Server Express...");
                    mySC.Refresh();
                    mySC.WaitForStatus(ServiceControllerStatus.Running);
                    //Console.WriteLine("SQL Server Express funcionando" + mySC.Status.ToString());

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao continuar o serviço do SQL Server Express: " + ex.Message, "Erro SQL Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMenu());
           
        }
    }
}
