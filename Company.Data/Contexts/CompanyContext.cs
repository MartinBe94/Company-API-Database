using Company.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Company.Data.Contexts;

public class CompanyContext: DbContext
{
    public DbSet<Entities.Company> Company=>Set<Entities.Company>();
    public DbSet<Department> Department => Set<Department>();
    public DbSet<Employee> Employee => Set<Employee>();
    public DbSet<Position> Position => Set<Position>();
    public DbSet<EmployeePosition> Employeeposition => Set<EmployeePosition>();

    public CompanyContext(DbContextOptions<CompanyContext> options): base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.Entity<EmployeePosition>().HasKey(ep => new { ep.EmployeeId, ep.PositionId });
        SeedData(builder);
    }
    private void SeedData(ModelBuilder builder)
    {
        var Company = new List<Entities.Company>
        {
            new Entities.Company{ Id = 1,
            CompanyName="Namco",
            OrganisationNumber="89323212"
            },
              new Entities.Company{ Id = 2,
            CompanyName="Alibaba",
            OrganisationNumber="42342342"
            },
                new Entities.Company{ Id = 3,
            CompanyName="Samsung",
            OrganisationNumber="64363884"
            },
                new Entities.Company{ Id = 4,
            CompanyName="Tesla",
            OrganisationNumber="88999123"
            }
        };
        builder.Entity<Entities.Company>().HasData(Company);

        var Department = new List<Department>
        {
            new Department{ Id = 1,
            CompanyId=1,
            DepartmentName="DEV"
            },
            new Department{ Id = 2,
            CompanyId=1,
            DepartmentName="Buisness"
            },
            new Department{ Id = 3,
            CompanyId=2,
            DepartmentName="DEV"
            },
            new Department{ Id = 4,
            CompanyId=2,
            DepartmentName="Buisness"
            },
            new Department{ Id = 5,
            CompanyId=2,
            DepartmentName="HardWare"
            },
            new Department{ Id = 6,
            CompanyId=3,
            DepartmentName="Buisness"
            },
            new Department{ Id = 7,
            CompanyId=3,
            DepartmentName="DEV"
            },
            new Department{ Id = 8,
            CompanyId=3,
            DepartmentName="HardWare"
            },
            new Department{ Id = 9,
            CompanyId=4,
            DepartmentName="HardWare"
            },
            new Department{ Id = 10,
            CompanyId=4,
            DepartmentName="Buisness"
            },
            new Department{ Id = 11,
            CompanyId=4,
            DepartmentName="DEV"
            }
        };
        builder.Entity<Department>().HasData(Department);

        var Employee = new List<Employee>
        {
            new Employee{ Id = 1,
            DepartmentId=1,
            FirstName="Katsuhiro",
            LastName="Harada",
            Salary=2500000,
            Union=true
            },
            new Employee{ Id = 2,
            DepartmentId=1,
            FirstName="Seiichi",
            LastName="Ishii",
            Salary=100000000,
            Union=true
            },
            new Employee{ Id = 3,
            DepartmentId=11,
            FirstName="Elon",
            LastName="Musk",
            Salary=1000000000,
            Union=true
            },
            new Employee{ Id = 4,
            DepartmentId=5,
            FirstName="Jack",
            LastName="Ma",
            Salary=100000000,
            Union=true
            }
        };
        builder.Entity<Employee>().HasData(Employee);

        var EmployeePosition = new List<EmployeePosition>
        {
            new EmployeePosition{EmployeeId=1,PositionId=1},
            new EmployeePosition{EmployeeId=1,PositionId=5},
            new EmployeePosition{EmployeeId=2,PositionId=2},
            new EmployeePosition{EmployeeId=2,PositionId=5},
            new EmployeePosition{EmployeeId=3,PositionId=1},
            new EmployeePosition{EmployeeId=3,PositionId=4},
            new EmployeePosition{EmployeeId=4,PositionId=1},
            new EmployeePosition{EmployeeId=4,PositionId=6},
        };
        builder.Entity<EmployeePosition>().HasData(EmployeePosition);

        var Position = new List<Position>
        {
            new Position{ Id = 1,
            PositionName="CEO"
            },
            new Position{ Id = 2,
            PositionName="Game DEV"
            },
            new Position{ Id = 3,
            PositionName="FrontDEV"
            },
            new Position{ Id = 4,
            PositionName="BackDEV"
            },
            new Position{ Id = 5,
            PositionName="FullstackDEV"
            },
            new Position{ Id = 6,
            PositionName="BuisnessChief"
            },
            new Position{ Id = 7,
            PositionName="UX Desginer"
            }
        };
        builder.Entity<Position>().HasData(Position);
    }
}
