﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCore.Identity.MongoDbCore.Models;
using MongoDbGenericRepository.Attributes;

namespace IAMServer.Models {
    [CollectionName("Users")]
    public class ApplicationUser : MongoIdentityUser<Guid> {

    }
}
