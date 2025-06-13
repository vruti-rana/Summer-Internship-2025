﻿using Mission.Entities;
using Mission.Entities.Models.CommonModels;

namespace Mission.Repositories.IRepositories
{
    public interface ICommonRepository
    {
        List<DropDownResponseModel> CountryList();

        List<DropDownResponseModel> CityList(int countryId);

        List<DropDownResponseModel> MissionCountryList();

        List<DropDownResponseModel> MissionCityList();

        List<DropDownResponseModel> MissionThemeList();

        List<DropDownResponseModel> MissionSkillList();

        List<DropDownResponseModel> MissionTitleList();
        List<DropDownResponseModel> GetUserSkill(int userId);
        Task<bool> AddUserSkill(UserSkills skills);
    }
}
