import java.rmi.RemoteException;
import java.rmi.server.UnicastRemoteObject;
import java.util.ArrayList;
import java.util.Collections;

public class CalcObjImpl extends UnicastRemoteObject implements CalcObject {
    private static final long serialVersionUID = 103L;
    public CalcObjImpl() throws RemoteException {
        super();
    }

    public ResultType calculate(InputType inParam) throws RemoteException {
        ArrayList<Integer> lista = inParam.getList();
        Collections.sort(lista);

        ResultType wynik = new ResultType();
        wynik.setList(lista);
        wynik.setResult(true);
        return wynik;
    }
}