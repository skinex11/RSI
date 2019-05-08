import org.apache.xmlrpc.XmlRpcClient;

import java.util.Vector;

public class klientRPC {
    public static void main(String args[]){
        try{
            XmlRpcClient srv = new XmlRpcClient("http://localhost:10000");//10000+nr stanowiska
            Vector<Integer> params = new Vector<Integer>();
            params.addElement(13);
            params.addElement(21);
            Object result = srv.execute("MojSerwer.echo", params);
            int wynik = ((Integer) result).intValue();
            System.out.println("Wynik: "+wynik);

            AC cb = new AC();
            Vector<Integer> params2 = new Vector<Integer>();
            params2.addElement(3000);
            srv.executeAsync("MojSerwer.execAsy", params2, cb);
            System.out.println("Wywolano asynchronicznie!");
        }
        catch (Exception exception){
            System.err.println("Klient XML-RPC: "+exception);
        }
    }
}
