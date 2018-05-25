![cf](http://i.imgur.com/7v5ASc8.png) Lab 10 : Recursion
=====================================


#### Factorial Example
1. The Factorial of N is written N! (pronounced "N Factorial")
```csharp
0! = 1
1! = 1
2! = 2 * 1! = 2
3! = 3 * 2! = 3 * 2* 2 * 0! = 3 * 2* 1* 1
```

Code for a non recursive approach:

```csharp
public long Factorial(int n)
{
    if (n == 0)
        return 1;
    long value = 1;
    for (int i = n; i > 0; i--)
    {
        value *= i;
    }
    return value;
}
```

Recursive approach:

```csharp
Long Factorial (Integer: n)
If(n==0) Then Return 1
Return n * Factorial(n-1)
End Factorial

public long Factorial(int n)
{
    if (n == 0) 
        return 1;
    return n * Factorial(n - 1);
}
```

- First, if the input value is equal to zero, the algorithm will return 1.
- If the input is not zero, the algorithm returns the number n times the factoiral of n-1.
- Very simple algorithm, but it demonstrates two impotant features taht all recursive algorithms must have
	1. Each time a method executes, it reduces the current problem to a smaller instance of the same problem and then calls itself to solve the smaller problem. 
		- in this example, the method reduces the problem by computing n! to the problem of computing (n-1)! and then multiplying by n. 

	2. the recursion must eventually stop. in this example, the input parameter n decreases with each recursive call until 
	it equals 0. At that point, the algorithm returns 1, and does not call itself recursively, so the process stops. 

	3. If the method above calls -1, the recusion never ends. it will go to `-1! = -1 * -2! etc...`
	4. A way to prevent this is to add a check that says `if(n <= 0) then return 1`. (issues with this is the misleading 1 that is being sent. may be better to just throw an exception)
	5. Factorial method can grow very very quickly. Be careful how you are using it.


#### Fibonacci Numbers
Review the Fibonocci Numbers.
<br />
<br />
1. Non recusion:

```csharp
public long Fib(int n)
{
    if (n < 2)
        return n;
    long[] f = new long[n+1];
    f[0] = 0;
    f[1] = 1;
    
    for (int i = 2; i <= n; i++)
    {
        f[i] = f[i - 1] + f[i - 2];
    }
    return f[n];
}
```

2. Recursion

```chsarp

public long Fib(int n)
{
    if (n == 0 || n == 1)
        return n;
    return Fib(n - 2) + Fib(n - 1);
}
```