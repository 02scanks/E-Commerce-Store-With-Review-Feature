﻿public class Review 
{
    public int ReviewID { get; set; }
    public int ProductID { get; set; }
    public int UserID { get; set; }
    public float Rating { get; set; }
    public string Comment { get; set; }
    public DateTime ReviewDate { get; set; }
}