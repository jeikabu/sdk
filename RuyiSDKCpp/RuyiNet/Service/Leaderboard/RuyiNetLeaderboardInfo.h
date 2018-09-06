#pragma once

#include "Response/RuyiNetGetGlobalLeaderboardVersionsResponse.h"
#include "RuyiNetLeaderboardType.h"
#include "RuyiNetRotationType.h"
#include "RuyiNetLeaderboardVersionInfo.h"

namespace Ruyi { namespace SDK { namespace Online {

	/// <summary>
	/// Represents a leaderboard on RuyiNet.
	/// </summary>
	class RuyiNetLeaderboardInfo
	{
	public:
		
		RuyiNetLeaderboardInfo() {}
		RuyiNetLeaderboardInfo(RuyiNetGetGlobalLeaderboardVersionsResponse::Data data) 
		{
			LeaderboardId = data.leaderboardId;
			LeaderboardType = ConvertStringToRuyiNetLeaderboardType(data.leaderboardType);
			RotationType = ConvertStringToRuyiNetRotationType(data.rotationType);
			RetainedCount = data.retainedCount;

			std::for_each(data.versions.begin(), data.versions.end(), [&](RuyiNetGetGlobalLeaderboardVersionsResponse::Data::VersionInfo& info) 
			{
				Versions.push_back(new RuyiNetLeaderboardVersionInfo(info));
			});
		}

		std::string GetLeaderboardId() { return LeaderboardId; }
		RuyiNetLeaderboardType GetLeaderboardType() { return LeaderboardType; }
		RuyiNetRotationType GetRotationType() { return RotationType; }
		int GetRetainedCount() { return RetainedCount; }
		std::vector<RuyiNetLeaderboardVersionInfo*>& GetVersions() { return Versions; }

	private:
		/// <summary>
        /// The ID of the leaderboard.
        /// </summary>
		std::string LeaderboardId;

        /// <summary>
        /// The type of leaderboard.
        /// </summary>
		RuyiNetLeaderboardType LeaderboardType;

        /// <summary>
        /// The type of leaderboard rotation.
        /// </summary>
		RuyiNetRotationType RotationType;

        /// <summary>
        /// The number of versions retained.
        /// </summary>
		int RetainedCount;

        /// <summary>
        /// A list of versions currently retained.
        /// </summary>
		std::vector<RuyiNetLeaderboardVersionInfo*> Versions;
	};
}}}