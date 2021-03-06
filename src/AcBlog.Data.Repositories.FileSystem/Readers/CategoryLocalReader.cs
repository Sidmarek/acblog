﻿using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace AcBlog.Data.Repositories.FileSystem.Readers
{
    public class CategoryLocalReader : CategoryReaderBase
    {
        public CategoryLocalReader(string rootPath) : base(rootPath)
        {
        }

        public override Task<bool> Exists(string id, CancellationToken cancellationToken = default)
        {
            return Task.FromResult(File.Exists(GetPath(id)));
        }

        protected override Task<Stream> GetFileReadStream(string path, CancellationToken cancellationToken = default)
        {
            return Task.FromResult<Stream>(File.Open(path, FileMode.Open, FileAccess.Read));
        }
    }
}
