using HealthyJourney.Data.Repositories;
using HealthyJourney.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyJourney.Data.Infrastructure
{
	public interface IUnitOfWork : IDisposable
	{
		void Commit();
        //void Rollback();

        IUserRepository UserRepository { get; }
        IInfosRepository InfosRepository { get; }


        IBadgeRepository BadgeRepository { get; }

        ISpecialityRepository SpecialityRepository { get; }

        IMedicalRecordRepository MedicalRecordRepository { get; }
        IForumRepository ForumRepository { get; }
        ICommentRepository CommentRepository { get; }

    }

}
