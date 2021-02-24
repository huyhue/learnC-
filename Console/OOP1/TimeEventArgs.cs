using System;
using System.Threading;
namespace OOP1
{
public class TimeEventArgs
{
    public DateTime timer{get;set;}
    public TimeEventArgs(DateTime t){
        timer = t;
    }
}
}