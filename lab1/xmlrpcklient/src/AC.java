import org.apache.xmlrpc.AsyncCallback;

import java.net.URL;

public class AC implements AsyncCallback {
    @Override
    public void handleResult(Object rezultat, URL url, String metoda) {
        System.out.println("handleResult");
    }

    @Override
    public void handleError(Exception e, URL url, String metoda) {
        System.out.println("handleError: "+e.getMessage());
    }
}
