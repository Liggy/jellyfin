﻿using System;
using System.Collections.Generic;

namespace MediaBrowser.Model.LiveTv
{
    public class SeriesTimerInfoDto
    {
        /// <summary>
        /// Id of the recording.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the external identifier.
        /// </summary>
        /// <value>The external identifier.</value>
        public string ExternalId { get; set; }
        
        /// <summary>
        /// ChannelId of the recording.
        /// </summary>
        public string ChannelId { get; set; }

        /// <summary>
        /// Gets or sets the name of the service.
        /// </summary>
        /// <value>The name of the service.</value>
        public string ServiceName { get; set; }

        /// <summary>
        /// Gets or sets the external channel identifier.
        /// </summary>
        /// <value>The external channel identifier.</value>
        public string ExternalChannelId { get; set; }
        
        /// <summary>
        /// ChannelName of the recording.
        /// </summary>
        public string ChannelName { get; set; }

        /// <summary>
        /// Gets or sets the program identifier.
        /// </summary>
        /// <value>The program identifier.</value>
        public string ProgramId { get; set; }

        /// <summary>
        /// Gets or sets the external program identifier.
        /// </summary>
        /// <value>The external program identifier.</value>
        public string ExternalProgramId { get; set; }
        
        /// <summary>
        /// Name of the recording.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Description of the recording.
        /// </summary>
        public string Overview { get; set; }

        /// <summary>
        /// The start date of the recording, in UTC.
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// The end date of the recording, in UTC.
        /// </summary>
        public DateTime EndDate { get; set; }

        /// <summary>
        /// Gets or sets the type of the recurrence.
        /// </summary>
        /// <value>The type of the recurrence.</value>
        public RecurrenceType RecurrenceType { get; set; }

        /// <summary>
        /// Gets or sets the days.
        /// </summary>
        /// <value>The days.</value>
        public List<DayOfWeek> Days { get; set; }

        /// <summary>
        /// Gets or sets the day pattern.
        /// </summary>
        /// <value>The day pattern.</value>
        public DayPattern? DayPattern { get; set; }

        /// <summary>
        /// Gets or sets the priority.
        /// </summary>
        /// <value>The priority.</value>
        public int Priority { get; set; }

        /// <summary>
        /// Gets or sets the requested pre padding seconds.
        /// </summary>
        /// <value>The requested pre padding seconds.</value>
        public int RequestedPrePaddingSeconds { get; set; }

        /// <summary>
        /// Gets or sets the requested post padding seconds.
        /// </summary>
        /// <value>The requested post padding seconds.</value>
        public int RequestedPostPaddingSeconds { get; set; }

        /// <summary>
        /// Gets or sets the required pre padding seconds.
        /// </summary>
        /// <value>The required pre padding seconds.</value>
        public int RequiredPrePaddingSeconds { get; set; }

        /// <summary>
        /// Gets or sets the required post padding seconds.
        /// </summary>
        /// <value>The required post padding seconds.</value>
        public int RequiredPostPaddingSeconds { get; set; }

        public SeriesTimerInfoDto()
        {
            Days = new List<DayOfWeek>();
        }
    }
}