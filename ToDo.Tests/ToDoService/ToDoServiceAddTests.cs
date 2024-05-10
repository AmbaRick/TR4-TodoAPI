﻿using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Core.Entities;
using ToDo.Core.Interfaces;
using ToDo.Core.ToDoItems;
using ToDo.Core;

namespace ToDo.Tests.ToDoService
{
    public class ToDoServiceAddTests
    {
        private readonly Mock<IToDoRepository> _toDoRepository;
        private readonly ToDoItemService _toDoService;

        public ToDoServiceAddTests()
        {
            _toDoRepository = new Mock<IToDoRepository>();
            _toDoService = new ToDoItemService(_toDoRepository.Object);
        }

      

       

       

       

       

       

      
    }

}

