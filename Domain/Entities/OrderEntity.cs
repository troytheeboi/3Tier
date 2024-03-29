﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Domain.Entities.Bases;

namespace Domain.Entities;

public class OrderEntity:BaseEntity
{
    [Required]
    public DateTime OrderDate { get; set; }
    [Required]
    public float Total { get; set; }

    [ForeignKey("CustomerEntity")]
    public int CustomerId { get; set; }

    [Required]
    public string Status { get; set; }

        
    public CustomerEntity customer { get; set; }
    [Required]
    public PaymentEntity payment { get; set; }

    public List<ProductEntity> products { get; set; }

}