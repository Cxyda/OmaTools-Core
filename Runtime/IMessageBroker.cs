
using System;

namespace Plugins.O.M.A.Games.Core
{
	/// <summary>
	/// The interface of the MessageBroker
	/// </summary>
	public interface IMessageBroker
	{
		void Subscribe<T>(Action<T> callback) where T : IMessage;
		void Subscribe<T>(int channel, Action<T> callback) where T : IMessage;
		
		void Unsubscribe<T>(Action<T> subscriber) where T : IMessage;
		void Unsubscribe<T>(int channel, Action<T> subscriber) where T : IMessage;
		void UnsubscribeAll(object subscriber);

		void Publish<T>(T message) where T : IMessage;
		void Publish<T>(int channel, T message) where T : IMessage;
	}
}
