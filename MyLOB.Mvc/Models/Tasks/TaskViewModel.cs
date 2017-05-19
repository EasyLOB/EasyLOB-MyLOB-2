﻿using EasyLOB.Data;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EasyLOB.Mvc
{
    public class TaskViewModel : IValidatableObject, IZValidatableObject
    {
        #region Properties

        public ZOperationResult OperationResult { get; set; }

        public string Controller { get; set; }

        public string Action { get; set; }

        public string Task { get; set; }

        #endregion Properties

        #region Methods

        public TaskViewModel()
        {
            OperationResult = new ZOperationResult();
        }

        public TaskViewModel(string controller, string action, string task)
            : this()
        {
            Controller = controller;
            Action = action;
            Task = task;
        }

        public virtual IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            return new List<ValidationResult>();
        }

        public virtual bool Validate(ZOperationResult operationResult)
        {
            return operationResult.Ok;
        }

        #endregion Methods
    }
}