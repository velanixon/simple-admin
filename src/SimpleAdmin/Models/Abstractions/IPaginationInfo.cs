﻿namespace SimpleAdmin.Models.Abstractions
{
    public interface IPaginationInfo
    {
        int PageNumber { get; }

        int PageSize { get; }
    }
}
