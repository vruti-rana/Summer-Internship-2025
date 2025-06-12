﻿using Mission.Entities.Models;
using Mission.Repositories.IRepositories;
using Mission.Services.IServices;

namespace Mission.Services.Services
{
    public class MissionService(IMissionRepository missionRepository, IMissionSkillRepository missionSkillRepository) : IMissionService
    {
        private readonly IMissionRepository _missionRepository = missionRepository;
        private readonly IMissionSkillRepository _missionSkillRepository = missionSkillRepository;

        public Task<bool> AddMission(MissionRequestViewModel model)
        {
            var mission = new Entities.Missions()
            {
                CityId = model.CityId,
                CountryId = model.CountryId,
                EndDate = model.EndDate,
                MissionDescription = model.MissionDescription,
                MissionImages = model.MissionImages,
                MissionSkillId = model.MissionSkillId,
                MissionThemeId = model.MissionThemeId,
                MissionTitle = model.MissionTitle,
                StartDate = model.StartDate,
                TotalSheets = model.TotalSeats,
            };

            return _missionRepository.AddMission(mission);
        }

        public Task<List<MissionRequestViewModel>> GetAllMissionAsync()
        {
            return _missionRepository.GetAllMissionAsync();
        }

        public Task<MissionRequestViewModel?> GetMissionById(int id)
        {
            return _missionRepository.GetMissionById(id);
        }

        // int userId
        public async Task<IList<MissionDetailResponseModel>> ClientSideMissionList()
        {
            var missions = await _missionRepository.ClientSideMissionList();

            return missions.Select(m => new MissionDetailResponseModel()
            {
                Id= m.Id,
                EndDate= m.EndDate,
                StartDate   = m.StartDate,
                MissionDescription  = m.MissionDescription,
                MissionImages= m.MissionImages,
                MissionTitle    = m.MissionTitle,
                TotalSheets = m.TotalSheets,
                RegistrationDeadLine = m.RegistrationDeadLine,
                CityId = m.CityId,
                CityName = m.City.CityName,
                CountryId = m.CountryId,
                CountryName= m.Country.CountryName,
                MissionSkillId = m.MissionSkillId,
                MissionSkillName = _missionSkillRepository.GetMissionSkills(m.MissionSkillId),
                MissionThemeId = m.MissionThemeId,
                MissionThemeName = m.MissionTheme.ThemeName
            }).ToList();

        }

    }
}
