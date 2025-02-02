﻿using System.ComponentModel.DataAnnotations;

namespace RecruitmentAgency;
/// <summary>
/// Company - a class that describes the company representative
/// </summary>
public class Company
{
    /// <summary>
    /// CompanyName - a string that stores the company name
    /// </summary>  
    public string CompanyName { set; get; } = string.Empty;
    /// <summary>
    /// ContactName - the string responsible for the name of the company representative
    /// </summary>  
    public string ContactName { set; get; } = string.Empty;
    /// <summary>
    /// Telephone - a string that stores the phone number
    /// </summary>
    public string Telephone { set; get; } = string.Empty;
    /// <summary>  
    /// id - shows the company's id
    /// </summary>  
    [Key]
    public int? Id { set; get; }
    /// <summary>
    /// Applications - shows the applications 
    /// </summary>
    public List<int>? Applications { set; get; } = new List<int>();
}
