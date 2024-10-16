class Tuple<T1, T2> {
    public T1 t1;
    public T2 t2;
    public Tuple(T1 t1, T2 t2) {
        this.t1 = t1;
        this.t2 = t2;
    }

    @Override
    public boolean equals(Object obj) {
        if (obj == null) {
            return false;
        }

        if (!(obj instanceof Tuple)){
            return false;
        }

        Tuple<T1,T2> other = (Tuple<T1,T2>) obj;

        return this.t1.equals(other.t1);
    }

    @Override
    public int hashCode() {
        return Objects.hash(t1);
    }
}

class Solution {
    public String longestDiverseString(int a, int b, int c) {
        List<Tuple<Character, Integer>> list = new ArrayList<>();
        if (a > 0) list.add(new Tuple('a', a));
        if (b > 0) list.add(new Tuple('b', b));
        if (c > 0) list.add(new Tuple('c', c));
        StringBuilder sb = new StringBuilder();
        Tuple<Character, Integer> banned = null;
        while (list.size() > 0) {
            var max = getMax(list);
            if (banned != null) {
                list.add(banned);
                banned = null;
            }
            if (sb.length() > 1 && sb.charAt(sb.length() - 1) == max.t1 && sb.charAt(sb.length() - 2) == max.t1) {
                list.remove(max);
                banned = max;
            }
            else {
                max.t2--;
                sb.append(max.t1);
                if (max.t2 <= 0) list.remove(max);
            }
        }
        return sb.toString();
    }

    private Tuple<Character, Integer> getMax(List<Tuple<Character, Integer>> list) {
        Tuple<Character, Integer> max = list.get(0);
        for (int i = 1; i < list.size(); i++)
        {
            if (max.t2 < list.get(i).t2) max = list.get(i);
        }
        return max;
    }
}