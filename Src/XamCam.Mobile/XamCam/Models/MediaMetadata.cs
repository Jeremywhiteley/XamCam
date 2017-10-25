﻿using System;

namespace XamCam
{
	public class MediaMetadata
	{
        public string Id { get; set; }
        public string MediaServicesAssetId { get; set; }
        public Uri MediaAssetUri { get; set; }
        public string FileName { get; set; }
        public DateTimeOffset UploadedAt { get; set; }
        public string Title { get; set; }
        public string ManifestUrl { get; set; }
        public string HLSUrl { get; set; }
        public string MPEGDashUrl { get; set; }
	}
}