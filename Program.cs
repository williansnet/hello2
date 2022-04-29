using System.Collections;

Stack st = new Stack();

st.Push('A');
st.Push('B');
st.Push('C');

/* st.Pop(); */
//st.Pop();
//st.Pop();

var stSize = st.Count;

Console.Write(stSize.ToString());
Console.WriteLine();
Console.Write(st.Contains('B'));