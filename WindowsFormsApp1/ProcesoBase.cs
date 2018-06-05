using System.Diagnostics;

namespace ShutdownBasic
{
    public class ProcesoBase
    {
        public ProcesoBase()
        {
        }

        public bool apagarSistema(double tiempo)
        {
            double tiempoCalculado = tiempo * 3600;
            Process p = new Process();
            p.EnableRaisingEvents = false;
            p.StartInfo.FileName = "C:\\WINDOWS\\system32\\shutdown.exe";
            p.StartInfo.Arguments = "-s -f -t " + tiempoCalculado;
            p.StartInfo.CreateNoWindow = false;
            p.Start();
            return true;
        }

        public bool reiniciarSistema(double tiempo)
        {
            double tiempoCalculado = tiempo * 3600;
            Process p = new Process();
            p.EnableRaisingEvents = false;
            p.StartInfo.FileName = "C:\\WINDOWS\\system32\\shutdown.exe";
            p.StartInfo.Arguments = "-r -f -t " + tiempoCalculado;
            p.StartInfo.CreateNoWindow = false;
            p.Start();
            return true;
        }

        public bool cerrarSesionSistema(double tiempo)
        {
            double tiempoCalculado = tiempo * 3600;
            Process p = new Process();
            p.EnableRaisingEvents = false;
            p.StartInfo.FileName = "C:\\WINDOWS\\system32\\shutdown.exe";
            p.StartInfo.Arguments = "-l -f -t " + tiempoCalculado;
            p.StartInfo.CreateNoWindow = false;
            p.Start();
            return true;
        }

        public void cancelarApagado()
        {
            Process p = new Process();
            p.EnableRaisingEvents = false;
            p.StartInfo.FileName = "C:\\WINDOWS\\system32\\shutdown.exe";
            p.StartInfo.Arguments = "-a";
            p.StartInfo.CreateNoWindow = false;
            p.Start();
        }

        public void abrirEnlace(string enlace = "")
        {
            ProcessStartInfo sInfo = new ProcessStartInfo(enlace);
            Process.Start(sInfo);
        }
    }
}