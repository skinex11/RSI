import java.io.Serializable;
import java.util.List;

public class InputType2 implements Serializable {
    private static final long serialVersionUID = 101L;
    private List <Integer> list;
    private List <Integer> list2;
    private int time;

    public List<Integer> getList() {
        return list;
    }
    public void setList(List<Integer> list) {
        this.list = list;
    }
    public List<Integer> getList2() {
        return list2;
    }
    public void setList2(List<Integer> list2) {
        this.list2 = list2;
    }
    public int getTime() {
        return time;
    }
    public void setTime(int time) {
        this.time = time;
    }


}