﻿using Classify.Domain.Configurations;
using Classify.Domain.Entities;
using Classify.Service.DTOs.Students;
using Classify.Service.DTOs.Users;
using System.Linq.Expressions;

namespace Classify.Service.Interfaces;

public interface IStudentService
{
    ValueTask<StudentForResultDto> AddAsync(StudentCreationDto studentCreationDto);
    ValueTask<IEnumerable<StudentForResultDto>> RetrieveAllAsync(
        PaginationParams @params, string search = null);
    ValueTask<IEnumerable<StudentForResultDto>> RetrieveByRegionAsync(
       PaginationParams @params, string search = null);
    bool RemoveAsync(int id);
    ValueTask<StudentForResultDto> RetrieveById(int id);
    ValueTask<StudentForResultDto> ModifyAsync(int id, StudentUpdateDto dto);



}
