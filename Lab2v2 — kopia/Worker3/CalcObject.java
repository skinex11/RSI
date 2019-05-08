import java.rmi.Remote;
import java.rmi.RemoteException;

public interface CalcObject extends Remote {
    public ResultType calculate(InputType2 inputParam)
            throws RemoteException;
}