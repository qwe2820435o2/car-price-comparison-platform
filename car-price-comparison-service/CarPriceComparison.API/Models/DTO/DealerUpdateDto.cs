﻿
namespace CarPriceComparison.API.Models;

public class DealerUpdateDto
{
    public long DealerId { get; set; }
    
    public string Name { get; set; }

    public string? Address { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? ZipCode { get; set; }

    public string? Country { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public string? Website { get; set; }
    
    public byte? Status { get; set; }  

}