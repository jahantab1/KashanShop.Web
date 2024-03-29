﻿using Kashanshop.Domain;
using Kashanshop.Domain.User;

public class OtpCode : BaseEntity
{
    public OtpCode()
    {
        ExpireDate=DateTime.Now.AddMinutes(5);
    }
    public string Code { get; set; }
    public DateTime ExpireDate { get; set; }
    public bool IsUsed { get; set; }
    public bool IsValid => !IsUsed && ExpireDate > DateTime.Now;
    public User User { get; set; }
    public int UserId { get; set; }
}