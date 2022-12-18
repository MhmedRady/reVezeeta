﻿using AutoMapper;
using System;
using vezeeta.DBL;

namespace vezeeta.BL;

public class AdminManager : IAdminManager
{
    private readonly IDepartmentRepo _adminRepo;
    private readonly IMapper _mapper;

    public AdminManager(IDepartmentRepo adminRepo, IMapper mapper)
    {
        this._adminRepo = adminRepo;
        this._mapper = mapper;
    }

    public List<AdminDTO> Index()
    {
        var adminRepoList = _adminRepo.Index();
        return _mapper.Map<List<AdminDTO>>(adminRepoList);
    }

    public void Add(AdminDTO admin)
    {
        throw new NotImplementedException();
    }

    public AdminDTO Delete(Guid id)
    {
        throw new NotImplementedException();
    }

    public AdminDTO? GetByID(Guid id)
    {
        throw new NotImplementedException();
    }

    public bool IsAdmin(AdminDTO admin)
    {
        throw new NotImplementedException();
    }

    public void Update(AdminDTO admin)
    {
        throw new NotImplementedException();
    }

    public AdminDTO? GetByUserName(string userName)
    {
        var admin = _adminRepo.GetByUserName(userName);
        if (admin == null)
            return null;
        var Admin = _mapper.Map<AdminDTO>(admin);
        return Admin;
    }
}
