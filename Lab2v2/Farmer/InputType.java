import java.io.Serializable;
import java.util.List;

public class InputType implements Serializable {
    private static final long serialVersionUID = 101L;
    private List <Integer> list;

    public List<Integer> getList() {
        return list;
    }
    public void setList(List<Integer> list) {
        this.list = list;
    }
}
