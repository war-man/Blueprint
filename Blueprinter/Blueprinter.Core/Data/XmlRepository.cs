using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Blueprinter.Core.Data
{
    public abstract class XmlRepository<TEntity> : IRepository<TEntity>
    {
        protected readonly List<TEntity> Records;
        protected readonly string Path;

        protected XmlRepository(string path)
        {
            Records = new List<TEntity>();
            Path = path;
        }
        protected virtual Predicate<TEntity> CreatePredicateFrom(Expression<Func<TEntity, bool>> expression)
        {
            return new Predicate<TEntity>(expression.Compile());
        }
        protected virtual void WriteFile()
        {
            var serializer = new XmlSerializer(Records.GetType());

            using (var writer = new StreamWriter(Path, false))
            {
                serializer.Serialize(writer, Records);
            }
        }
        protected virtual void ReadFile()
        {
            var contents = string.Empty;
            if (File.Exists(Path))
            {
                contents = File.ReadAllText(Path);
            }
            if (string.IsNullOrWhiteSpace(contents))
            {
                return;
            }
            var serializer = new XmlSerializer(Records.GetType());
            using (var reader = new StringReader(contents))
            {
                var records = (List<TEntity>)serializer.Deserialize(reader);

                Records.Clear();
                Records.AddRange(records);
            }
        }

        public IEnumerable<TEntity> All()
        {
            return Records.ToArray();
        }

        public bool Any(Expression<Func<TEntity, bool>> predicate)
        {
            var func = predicate.Compile();
            return Records.Any(func);
        }

        public int Count
        {
            get { return Records.Count; }
        }

        public abstract TEntity Create(TEntity t);

        public abstract int Delete(TEntity t);

        public int Delete(Expression<Func<TEntity, bool>> predicate)
        {
            var pred = CreatePredicateFrom(predicate);
            return Records.RemoveAll(pred);

        }

        public TEntity Find(Expression<Func<TEntity, bool>> predicate)
        {
            var pred = CreatePredicateFrom(predicate);
            return Records.Find(pred);
        }

        public IEnumerable<TEntity> FindAll(Expression<Func<TEntity, bool>> predicate)
        {
            var pred = CreatePredicateFrom(predicate);
            return Records.FindAll(pred);
        }

        public abstract int Update(TEntity t);
    }
}

