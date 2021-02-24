using System;
using System.Threading;
namespace OOP1
{
public class Clock
{
    public delegate void SecondHandle(object o, TimeEventArgs e);
    public event SecondHandle OnSecondChange;
    public void Run(){
        while(true){
            Thread.Sleep(1000);
            if (OnSecondChange != null)
            {
                DateTime t = DateTime.Now;
                OnSecondChange(this,new TimeEventArgs(t));
            }
        }
    }
    
}
}