﻿namespace RecruitmentAgencyServer.Dto;
/// <summary>
/// JobApplication - a class that describes the employee's application
/// </summary>
public class JobApplicationPostDto
{
    /// <summary>
    /// Employee - contains employee id
    /// </summary>  
    public int EmployeeId { get; set; }
    /// <summary>
    /// Date - date of application
    /// </summary>  
    public DateTime Date { set; get; }
    /// <summary>
    /// Title - responsible for the job title id
    /// </summary>
    public int TitleId { set; get; }
}


