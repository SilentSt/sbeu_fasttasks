using Microsoft.AspNetCore.Identity;

using SBEU.Tasklet.Models.Enums;

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBEU.Tasklet.Models.Responses
{
    public class TaskDto
    {
        [NotNull]
        public string Id { get; set; }
        [NotNull]
        public string Title { get; set; }
        [NotNull]
        public string Description { get; set; }
        [NotNull]
        public DateTime StartTime { get; set; }
        [NotNull]
        public uint Duration { get; set; }
        [NotNull]
        public TaskProgress Status { get; set; }
        public List<string> Links { get; set; }
        [NotNull]
        public bool Hidden { get; set; }
        public string Note { get; set; }
        [NotNull]
        public UserDto Author { get; set; }
        [NotNull]
        public bool IsAuthor { get; set; }
        [NotNull]
        public UserDto Executor { get; set; }
        [NotNull]
        public bool IsExecutor { get; set; }
        [NotNull]
        public uint Price { get; set; }
    }
}
