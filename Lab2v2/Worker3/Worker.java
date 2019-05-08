//Wasielewski Wojciech, 181165
import java.rmi.RemoteException;
import java.rmi.registry.LocateRegistry;
import java.rmi.registry.Registry;


public class Worker{
    public static void main(String[] args)	{

        if (args.length == 0) {
            System.out.println("You have to enter RMI object address in	the form: //host_address/service_name");
            return;
        }

        if (System.getSecurityManager() == null)
            System.setSecurityManager(new SecurityManager());

        try {
            Registry reg = LocateRegistry.createRegistry(10097);
        } catch (RemoteException e1) {
            e1.printStackTrace();
        }

        try {
            CalcObjImpl implObiektu = new CalcObjImpl();
            java.rmi.Naming.rebind(args[0], implObiektu);
            System.out.println("Worker is registered now :-)");
            System.out.println("Press Crl+C to stop...");
        } catch (Exception e) {
            System.out.println("WORKER CAN'T BE REGISTERED!");
            e.printStackTrace();
            return;
        }
    }
}