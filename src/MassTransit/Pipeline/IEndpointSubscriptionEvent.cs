﻿// Copyright 2007-2011 Chris Patterson, Dru Sellers, Travis Smith, et. al.
//  
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use 
// this file except in compliance with the License. You may obtain a copy of the 
// License at 
// 
//     http://www.apache.org/licenses/LICENSE-2.0 
// 
// Unless required by applicable law or agreed to in writing, software distributed 
// under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
// CONDITIONS OF ANY KIND, either express or implied. See the License for the 
// specific language governing permissions and limitations under the License.
namespace MassTransit.Pipeline
{
	using System;

	/// <summary>
	/// Interface that implementors wishing to be notified on subscription events should
	/// implement.
	/// </summary>
	public interface IEndpointSubscriptionEvent
	{
		UnsubscribeAction SubscribedTo<TMessage>(Uri endpointUri)
			where TMessage : class;

		UnsubscribeAction SubscribedTo<TMessage, TKey>(TKey correlationId, Uri endpointUri)
			where TMessage : class, CorrelatedBy<TKey>;
	}
}