// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IWorkbookChartDataLabelsRequest.
    /// </summary>
    public partial interface IWorkbookChartDataLabelsRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified WorkbookChartDataLabels using PUT.
        /// </summary>
        /// <param name="workbookChartDataLabelsToCreate">The WorkbookChartDataLabels to create.</param>
        /// <returns>The created WorkbookChartDataLabels.</returns>
        System.Threading.Tasks.Task<WorkbookChartDataLabels> CreateAsync(WorkbookChartDataLabels workbookChartDataLabelsToCreate);        /// <summary>
        /// Creates the specified WorkbookChartDataLabels using PUT.
        /// </summary>
        /// <param name="workbookChartDataLabelsToCreate">The WorkbookChartDataLabels to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WorkbookChartDataLabels.</returns>
        System.Threading.Tasks.Task<WorkbookChartDataLabels> CreateAsync(WorkbookChartDataLabels workbookChartDataLabelsToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified WorkbookChartDataLabels.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified WorkbookChartDataLabels.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified WorkbookChartDataLabels.
        /// </summary>
        /// <returns>The WorkbookChartDataLabels.</returns>
        System.Threading.Tasks.Task<WorkbookChartDataLabels> GetAsync();

        /// <summary>
        /// Gets the specified WorkbookChartDataLabels.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WorkbookChartDataLabels.</returns>
        System.Threading.Tasks.Task<WorkbookChartDataLabels> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified WorkbookChartDataLabels using PATCH.
        /// </summary>
        /// <param name="workbookChartDataLabelsToUpdate">The WorkbookChartDataLabels to update.</param>
        /// <returns>The updated WorkbookChartDataLabels.</returns>
        System.Threading.Tasks.Task<WorkbookChartDataLabels> UpdateAsync(WorkbookChartDataLabels workbookChartDataLabelsToUpdate);

        /// <summary>
        /// Updates the specified WorkbookChartDataLabels using PATCH.
        /// </summary>
        /// <param name="workbookChartDataLabelsToUpdate">The WorkbookChartDataLabels to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated WorkbookChartDataLabels.</returns>
        System.Threading.Tasks.Task<WorkbookChartDataLabels> UpdateAsync(WorkbookChartDataLabels workbookChartDataLabelsToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookChartDataLabelsRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookChartDataLabelsRequest Expand(Expression<Func<WorkbookChartDataLabels, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookChartDataLabelsRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookChartDataLabelsRequest Select(Expression<Func<WorkbookChartDataLabels, object>> selectExpression);

    }
}
