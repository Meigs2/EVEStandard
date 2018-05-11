﻿using System.Collections.Generic;
using System.Threading.Tasks;
using EVEStandard.Enumerations;
using EVEStandard.Models;
using EVEStandard.Models.API;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace EVEStandard.API
{
    public class Assets : APIBase
    {
        private ILogger Logger { get; } = LibraryLogging.CreateLogger<Assets>();
        internal Assets(string dataSource) : base(dataSource)
        {
        }

        public async Task<ESIModelDTO<List<Asset>>> GetCharacterAssetsV3Async(AuthDTO auth, int page)
        {
            checkAuth(auth, Scopes.ESI_ASSETS_READ_ASSETS_1);

            var queryParameters = new Dictionary<string, string>
            {
                { "page", page.ToString() }
            };

            var responseModel = await GetAsync("/v3/characters/" + auth.Character.CharacterID + "/assets/", auth, queryParameters);

            checkResponse("GetCharacterAssetsV3Async", responseModel.Error, responseModel.Message, responseModel.LegacyWarning, Logger);

            return returnModelDTO<List<Asset>>(responseModel);
        }

        public async Task<ESIModelDTO<List<Asset>>> GetCorporationAssetsV2Async(AuthDTO auth, int corporationId, int page)
        {
            checkAuth(auth, Scopes.ESI_ASSETS_READ_CORP_ASSETS_1);

            var queryParameters = new Dictionary<string, string>
            {
                { "page", page.ToString() }
            };

            var responseModel = await GetAsync("/v2/corporations/" + corporationId + "/assets/", auth, queryParameters);

            checkResponse("GetCorporationAssetsV2Async", responseModel.Error, responseModel.Message, responseModel.LegacyWarning, Logger);

            return returnModelDTO<List<Asset>>(responseModel);
        }

        public async Task<ESIModelDTO<List<AssetName>>> GetCharacterAssetNamesV1Async(AuthDTO auth, List<long> itemIds)
        {
            checkAuth(auth, Scopes.ESI_ASSETS_READ_ASSETS_1);

            var responseModel = await PostAsync("/v1/characters/" + auth.Character.CharacterID + "/assets/names/", auth, itemIds);

            checkResponse("GetCharacterAssetNamesV1Async", responseModel.Error, responseModel.Message, responseModel.LegacyWarning, Logger);

            return returnModelDTO<List<AssetName>>(responseModel);
        }

        public async Task<ESIModelDTO<List<AssetLocation>>> GetCharacterAssetLocationsV2Async(AuthDTO auth, List<long> itemIds)
        {
            checkAuth(auth, Scopes.ESI_ASSETS_READ_ASSETS_1);

            var responseModel = await PostAsync("/v2/characters/" + auth.Character.CharacterID + "/assets/locations/", auth, itemIds);

            checkResponse("GetCharacterAssetLocationsV2Async", responseModel.Error, responseModel.Message, responseModel.LegacyWarning, Logger);

            return returnModelDTO<List<AssetLocation>>(responseModel);
        }

        public async Task<ESIModelDTO<List<AssetName>>> GetCorporationAssetNamesV1Async(AuthDTO auth, List<long> itemIds, long corpId)
        {
            checkAuth(auth, Scopes.ESI_ASSETS_READ_CORP_ASSETS_1);

            var responseModel = await PostAsync("/v1/corporations/" + corpId + "/assets/names/", auth, itemIds);

            checkResponse("GetCorporationAssetNamesV1Async", responseModel.Error, responseModel.Message, responseModel.LegacyWarning, Logger);

            return returnModelDTO<List<AssetName>>(responseModel);
        }

        public async Task<ESIModelDTO<List<AssetLocation>>> GetCorporationAssetLocationsV2Async(AuthDTO auth, List<long> itemIds, long corpId)
        {
            checkAuth(auth, Scopes.ESI_ASSETS_READ_CORP_ASSETS_1);

            var responseModel = await PostAsync("/v2/corporations/" + corpId + "/assets/locations/", auth, itemIds);

            checkResponse("GetCorporationAssetLocationsV2Async", responseModel.Error, responseModel.Message, responseModel.LegacyWarning, Logger);

            return returnModelDTO<List<AssetLocation>>(responseModel);
        }
    }
}
