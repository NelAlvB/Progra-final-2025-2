﻿using System;
using System.Collections.Generic;

namespace myFirtsProject.Models;

public partial class vProductAndDescription
{
    public int ProductID { get; set; }

    public string Culture { get; set; } = null!;

    public string Description { get; set; } = null!;
}
