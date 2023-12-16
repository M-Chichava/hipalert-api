using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Persistence
{
   
    public static  class DataContextSeed
    {
       
        public static async Task SeedAsync(DataContext context, ILoggerFactory loggerFactory, 
            UserManager<AppUser> userManager, IConfiguration configuration, RoleManager<IdentityRole> roleManager)
        {
            try
            {
                if (!context.WearableManufacturers.Any())
                {
                    await context.AddAsync(
                        new WearableManufacturer
                        {
                            Description = "Apple"
                        }
                    );

                    await context.AddAsync(
                        new WearableManufacturer
                        {
                            Description = "Samsung"
                        }
                    );

                    await context.AddAsync(
                        new WearableManufacturer
                        {
                            Description = "Fitbit"
                        }
                    );

                    await context.AddAsync(
                        new WearableManufacturer
                        {
                            Description = "Garmin"
                        }
                    );

                    await context.AddAsync(
                        new WearableManufacturer
                        {
                            Description = "Xiaomi"
                        }
                    );

                    await context.AddAsync(
                        new WearableManufacturer
                        {
                            Description = "Huawei"
                        }
                    );

                    await context.AddAsync(
                        new WearableManufacturer
                        {
                            Description = "Fossil"
                        }
                    );

                    await context.AddAsync(
                        new WearableManufacturer
                        {
                            Description = "Amazfit"
                        }
                    );

                    await context.AddAsync(
                        new WearableManufacturer
                        {
                            Description = "Polar"
                        }
                    );

                    await context.AddAsync(
                        new WearableManufacturer
                        {
                            Description = "Misfit"
                        }
                    );

                    await context.AddAsync(
                        new WearableManufacturer
                        {
                            Description = "Withings"
                        }
                    );

                    await context.AddAsync(
                        new WearableManufacturer
                        {
                            Description = "TicWatch"
                        }
                    );

                    await context.AddAsync(
                        new WearableManufacturer
                        {
                            Description = "Suunto"
                        }
                    );

                    await context.AddAsync(
                        new WearableManufacturer
                        {
                            Description = "Lenovo"
                        }
                    );

                    await context.AddAsync(
                        new WearableManufacturer
                        {
                            Description = "Honor"
                        }
                    );

                    await context.AddAsync(
                        new WearableManufacturer
                        {
                            Description = "Sony"
                        }
                    );

                    await context.AddAsync(
                        new WearableManufacturer
                        {
                            Description = "LG"
                        }
                    );

                    await context.AddAsync(
                        new WearableManufacturer
                        {
                            Description = "Bose"
                        }
                    );

                    await context.AddAsync(
                        new WearableManufacturer
                        {
                            Description = "Jabra"
                        }
                    );

                    await context.AddAsync(
                        new WearableManufacturer
                        {
                            Description = "Skagen"
                        }
                    );

                    await context.AddAsync(
                        new WearableManufacturer
                        {
                            Description = "Emporio"
                        }
                    );
                    
                    await context.AddAsync(
                        new WearableManufacturer
                        {
                            Description = "Armani"
                        }
                    );

                    await context.AddAsync(
                        new WearableManufacturer
                        {
                            Description = "TAG"
                        }
                    );
                    
                    await context.AddAsync(
                        new WearableManufacturer
                        {
                            Description = "Heuer"
                        }
                    );

                    await context.AddAsync(
                        new WearableManufacturer
                        {
                            Description = "Diesel"
                        }
                    );

                    await context.AddAsync(
                        new WearableManufacturer
                        {
                            Description = "Michael"
                        }
                    );
                    
                    await context.AddAsync(
                        new WearableManufacturer
                        {
                            Description = "Kors"
                        }
                    );
                    
                    await context.AddAsync(
                        new WearableManufacturer
                        {
                            Description = "Asus"
                        }
                    );

                    await context.AddAsync(
                        new WearableManufacturer
                        {
                            Description = "Oppo"
                        }
                    );

                    await context.AddAsync(
                        new WearableManufacturer
                        {
                            Description = "OnePlus"
                        }
                    );

                    await context.AddAsync(
                        new WearableManufacturer
                        {
                            Description = "Realme"
                        }
                    );

                    await context.AddAsync(
                        new WearableManufacturer
                        {
                            Description = "Cat"
                        }
                    );

                    await context.AddAsync(
                        new WearableManufacturer
                        {
                            Description = "Alcatel"
                        }
                    );

                    await context.AddAsync(
                        new WearableManufacturer
                        {
                            Description = "Eufy"
                        }
                    );

                    await context.AddAsync(
                        new WearableManufacturer
                        {
                            Description = "Matrix"
                        }
                    );

                    await context.AddAsync(
                        new WearableManufacturer
                        {
                            Description = "Moov"
                        }
                    );

                    await context.AddAsync(
                        new WearableManufacturer
                        {
                            Description = "MyKronoz"
                        }
                    );

                    await context.AddAsync(
                        new WearableManufacturer
                        {
                            Description = "Nextbit"
                        }
                    );

                    await context.AddAsync(
                        new WearableManufacturer
                        {
                            Description = "Razer"
                        }
                    );

                    await context.AddAsync(
                        new WearableManufacturer
                        {
                            Description = "Snap"
                        }
                    );
                    
                    await context.AddAsync(
                        new WearableManufacturer
                        {
                            Description = "Spectacles"
                        }
                    );
                    
                    await context.AddAsync(
                        new WearableManufacturer
                        {
                            Description = "Timex"
                        }
                    );

                    await context.AddAsync(
                        new WearableManufacturer
                        {
                            Description = "Vaer"
                        }
                    );

                    await context.AddAsync(
                        new WearableManufacturer
                        {
                            Description = "Vector"
                        }
                    );

                    await context.AddAsync(
                        new WearableManufacturer
                        {
                            Description = "Watch"
                        }
                    );

                    await context.AddAsync(
                        new WearableManufacturer
                        {
                            Description = "Zeblaze"
                        }
                    );

                    await context.AddAsync(
                        new WearableManufacturer
                        {
                            Description = "2Morrow"
                        }
                    );

                    await context.AddAsync(
                        new WearableManufacturer
                        {
                            Description = "3Plus"
                        }
                    );

                    await context.AddAsync(
                        new WearableManufacturer
                        {
                            Description = "4iiii"
                        }
                    );

                    await context.AddAsync(
                        new WearableManufacturer
                        {
                            Description = "9NINE"
                        }
                    );

                    await context.AddAsync(
                        new WearableManufacturer
                        {
                            Description = "100plus"
                        }
                    );

                    await context.AddAsync(
                        new WearableManufacturer
                        {
                            Description = "3M"
                        }
                    );

                    await context.AddAsync(
                        new WearableManufacturer
                        {
                            Description = "23andMe"
                        }
                    );

                    await context.AddAsync(
                        new WearableManufacturer
                        {
                            Description = "42Gears"
                        }
                    );

                    await context.SaveChangesAsync();
                }
               
                if (!context.Permissions.Any())
                {
//HealthCareProfessional
                    await context.AddAsync(
                        new Permission
                        {
                            Name = "PatientManagement",
                            Description = "Patient Management"
                        }
                    );                    
                    
                    await context.AddAsync(
                        new Permission
                        {
                            Name = "ViewPatientRecords",
                            Description = "View Patient Records"
                        }
                    );

                    await context.AddAsync(
                        new Permission
                        {
                            Name = "UpdatePatientRecords",
                            Description = "Update Patient Records"
                        }
                    );

                    await context.AddAsync(
                        new Permission
                        {
                            Name = "AccessMedicalHistory",
                            Description = "Access Medical History"
                        }
                    );

                    await context.AddAsync(
                        new Permission
                        {
                            Name = "RecordVitalSigns",
                            Description = "Record Vital Signs"
                        }
                    );

                    await context.AddAsync(
                        new Permission
                        {
                            Name = "ScheduleAppointments",
                            Description = "Schedule Appointments"
                        }
                    );

                    await context.AddAsync(
                        new Permission
                        {
                            Name = "PrescriptionManagement",
                            Description = "Prescription Management"
                        }
                    );

                    await context.AddAsync(
                        new Permission
                        {
                            Name = "DiagnosticTests",
                            Description = "Diagnostic Tests"
                        }
                    );

                    await context.AddAsync(
                        new Permission
                        {
                            Name = "ViewTestResults",
                            Description = "View Test Results"
                        }
                    );

                    await context.AddAsync(
                        new Permission
                        {
                            Name = "Communicate",
                            Description = "Communicate"
                        }
                    );


// Wearables
                    await context.AddAsync(
                        new Permission
                        {
                            Name = "DataCollection",
                            Description = "Data Collection"
                        }
                    );

                    await context.AddAsync(
                        new Permission
                        {
                            Name = "Connectivity",
                            Description = "Connectivity"
                        }
                    );

                    await context.AddAsync(
                        new Permission
                        {
                            Name = "DataTransmission",
                            Description = "Data Transmission"
                        }
                    );

                    await context.AddAsync(
                        new Permission
                        {
                            Name = "PrivacySecurity",
                            Description = "Privacy and Security"
                        }
                    );

//SystemAdmin
                    await context.AddAsync(
                        new Permission
                        {
                            Name = "UserManagement",
                            Description = "User Management"
                        }
                    );

                    await context.AddAsync(
                        new Permission
                        {
                            Name = "RoleManagement",
                            Description = "Role Management"
                        }
                    );

                    await context.AddAsync(
                        new Permission
                        {
                            Name = "AccessControl",
                            Description = "Access Control"
                        }
                    );

                    await context.AddAsync(
                        new Permission
                        {
                            Name = "Configuration",
                            Description = "Configuration and Settings"
                        }
                    );

                    await context.AddAsync(
                        new Permission
                        {
                            Name = "DataManagement",
                            Description = "Data Management"
                        }
                    );

                    await context.AddAsync(
                        new Permission
                        {
                            Name = "AuditTrails",
                            Description = "Audit Trails"
                        }
                    );

                    await context.AddAsync(
                        new Permission
                        {
                            Name = "BackupRecovery",
                            Description = "Backup and Recovery"
                        }
                    );
                    
                    await context.SaveChangesAsync();
                }
                if (!context.DocumentTypes.Any())
                {
                    await context.AddAsync(
                        new DocumentType
                        {
                            Description = "Bilhete de Identidade"
                        });
                    await context.AddAsync(
                        new DocumentType
                        {
                            Description = "Passaporte"
                        });
                    await context.AddAsync(
                        new DocumentType
                        {
                            Description = "Carta de Conducao"
                        });
                    await context.SaveChangesAsync();
                }
       
                if (!context.MaritalStatus.Any())
                {
                    await context.AddAsync(
                        new MaritalStatus
                        {
                            Description = "Solteiro"
                        });
                    await context.AddAsync(
                        new MaritalStatus
                        {
                            Description = "Casado"
                        });
                    await context.AddAsync(
                        new MaritalStatus
                        {
                            Description = "Divorciado"
                        });
                    await context.AddAsync(
                        new MaritalStatus
                        {
                            Description = "Viuvo"
                        });
                  await  context.SaveChangesAsync();
                }
                
                if (!context.Roles.Any())
                {
                    await context.AddAsync(
                        new Role
                        {
                            Name = "WearableDevice",
                            Description = "Wearable Device"
                        }
                    );

                    await context.AddAsync(
                        new Role
                        {
                            Name = "Administrator",
                            Description = "System Administrator"
                        }
                    );

                    await context.AddAsync(
                        new Role
                        {
                            Name = "HealthCareProfessional",
                            Description = "Health Care Professional"
                        }
                    );
                    
                    await context.SaveChangesAsync();
                }
                
                if (!context.RolePermissions.Any())
                {

                    var rolesPermissions = new List<RolePermissionsAux>();

                    var adminPermissions = new List<string>();
                    var healCareProfPermissions = new List<string>();
                    var wearablesPermissions = new List<string>();
                    
                    adminPermissions.Add(new string ("UserManagement"));
                    adminPermissions.Add(new string ("RoleManagement"));
                    adminPermissions.Add(new string ("AccessControl"));
                    adminPermissions.Add(new string ("Configuration"));
                    adminPermissions.Add(new string ("DataManagement"));
                    adminPermissions.Add(new string ("AuditTrails"));
                    adminPermissions.Add(new string ("BackupRecovery"));
                    
                    wearablesPermissions.Add(new string("DataCollection"));
                    wearablesPermissions.Add(new string("Connectivity"));
                    wearablesPermissions.Add(new string("DataTransmission"));
                    wearablesPermissions.Add(new string("PrivacySecurity"));
                    
                    healCareProfPermissions.Add(new string("PatientManagement"));
                    healCareProfPermissions.Add(new string("ViewPatientRecords"));
                    healCareProfPermissions.Add(new string("UpdatePatientRecords"));
                    healCareProfPermissions.Add(new string("AccessMedicalHistory"));
                    healCareProfPermissions.Add(new string("RecordVitalSigns"));
                    healCareProfPermissions.Add(new string("ScheduleAppointments"));
                    healCareProfPermissions.Add(new string("PrescriptionManagement"));
                    healCareProfPermissions.Add(new string("DiagnosticTests"));
                    healCareProfPermissions.Add(new string("ViewTestResults"));
                    healCareProfPermissions.Add(new string("Communicate"));

                    rolesPermissions.Add(new RolePermissionsAux
                     {
                         Role = "Administrator",
                         Permissions = adminPermissions
                     });
                     rolesPermissions.Add(new RolePermissionsAux
                     {
                         Role = "HealthCareProfessional",
                         Permissions = healCareProfPermissions
                     });
                     rolesPermissions.Add(new RolePermissionsAux
                     {
                         Role = "WearableDevice",
                         Permissions = wearablesPermissions
                     });
                    
                    foreach (var rolePermission in rolesPermissions)
                    {
                        var role = await context.Roles.Where(x => x.Name == rolePermission.Role)
                            .FirstOrDefaultAsync();

                        foreach (var permission in rolePermission.Permissions)
                        {
                            var appPermission = await context.Permissions.Where(x => x.Name == permission)
                                .FirstOrDefaultAsync();

                            
                                var appRolePermissions = new RolePermission
                                {
                                    Role = role,
                                    Permission = appPermission
                                }; 
                                await context.AddAsync(appRolePermissions);
                        }
                    }
                }
                if (!userManager.Users.Any())
                {
                       
                    var adminUsers = new List<AppUser>();
                    var healthCareProfessionalUsers = new List<AppUser>();
                    
                    adminUsers.Add(new AppUser
                    {
                        Email ="chichava@hipalert.com",
                        FullName = "Marcos Chichava",
                        UserName = "chichava@hipalert.com",
                        EmailConfirmed = true,
                        PhoneNumber = "840000000" ,
                        PhoneNumberConfirmed = true
                    });
                    healthCareProfessionalUsers.Add(new AppUser
                    {
                        Email = "jeremias@hipalert.com",
                        FullName = "Jeremias Tsenani",
                        UserName = "jeremias@hipalert.com",
                        EmailConfirmed = true,
                        PhoneNumber = "840000001",
                        PhoneNumberConfirmed = true
                    });
                    healthCareProfessionalUsers.Add(new AppUser
                    {
                        Email = "isabelmausse@hipalert.com",
                        FullName =  "Isabel Mausse",
                        UserName = "isabelmausse@hipalert.com",
                        EmailConfirmed = true,
                        PhoneNumber = "840000002",
                        PhoneNumberConfirmed = true
                    });
                    
                    healthCareProfessionalUsers.Add(new AppUser
                    {
                        Email = "celsoboaz@hipalert.com",
                        FullName =  "Celso Andre Boaz",
                        UserName = "celsoboaz@hipalert.com",
                        EmailConfirmed = true,
                        PhoneNumber = "840000003",
                        PhoneNumberConfirmed = true
                    });
                    
                    var roleAdmin =
                        await context.Roles.FirstOrDefaultAsync(x => x.Name == "Administrator");
             
                    var roleUserHealthCareProfessional =
                        await context.Roles.FirstOrDefaultAsync(x => x.Name == "HealthCareProfessional");

                    foreach (var item in adminUsers)
                    {
                        item.Role = roleAdmin;
                        await userManager.CreateAsync(item, "Pa55w.icor@2021#2021");
                        context.AddAsync(new Administrator
                        {
                            AppUser = item
                        });
                    }
                    
                    foreach (var item in healthCareProfessionalUsers)
                    {
                        item.Role = roleUserHealthCareProfessional;
                        await userManager.CreateAsync(item, "Pa55w.icor@2023@2024");
                        context.AddAsync(new HealthCareProfessional
                        {
                            AppUser = item
                        });
                    }

                    await context.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                var logger = loggerFactory.CreateLogger<DataContext>();
                logger.LogError(ex, ex.Message);
            }
        }
    }
}