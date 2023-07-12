using System;
namespace DelegatesDemo
{
    public class WorkPerformedEventArgs : EventArgs
    {
        public int Hours { get; set; }
        public WorkType WorkType { get; set; }
    }
}