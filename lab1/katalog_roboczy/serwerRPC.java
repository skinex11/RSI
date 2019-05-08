import org.apache.xmlrpc.WebServer;

public class serwerRPC {
    public static void main (String args[]){
        try {
            System.out.println("Startuje serwer XML-RPC...");
            int port = 10000;//+nr komputera w laboratorium
            WebServer server = new WebServer(port);

            //poniżej tworzy się obiekt swojej klasy serwera i uruchamia się go:
            server.addHandler("MojSerwer", new serwerRPC());
            server.start();
            System.out.println("Serwer wystartowal pomyslnie.");
            System.out.println("Nasluchuje na procie: "+port);
            System.out.println("Aby zatrzymac serwer nacisnij ctrl+c");
        }
        catch (Exception exception){
            System.err.println("Serwer XML-RPC: "+exception);
        }
    }

    public int echo(int a, int b){
        return a+b;
    }

    public int execAsy(int x){
        System.out.println("Wywolano asy - odliczam");
        try{
            Thread.sleep(x);
        }
        catch (InterruptedException ex){
            ex.printStackTrace();
            Thread.currentThread().interrupt();
        }
        System.out.println("asy - koniec odliczania");
        return 123;
    }
}
