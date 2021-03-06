using System;
using System.Collections.Generic;

namespace GraphQL.Common.Request {

	public class GraphQLSubscriptionRequest : IEquatable<GraphQLSubscriptionRequest> {

		public string Id { get; set; }

		public string Type { get; set; }

		public GraphQLRequest Payload { get; set; }

		/// <inheritdoc />
		public override bool Equals(object obj) => this.Equals(obj as GraphQLSubscriptionRequest);

		/// <inheritdoc />
		public bool Equals(GraphQLSubscriptionRequest other) {
			if (other == null) {
				return false;
			}
			if (ReferenceEquals(this, other)) {
				return true;
			}
			if (!Equals(this.Id, other.Id)) {
				return false;
			}
			if (!Equals(this.Type, other.Type)) {
				return false;
			}
			if (!Equals(this.Payload, other.Payload)) {
				return false;
			}
			return true;
		}

		/// <inheritdoc />
		public override int GetHashCode() {
			var hashCode = 9958074;
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Id);
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Type);
			hashCode = hashCode * -1521134295 + EqualityComparer<GraphQLRequest>.Default.GetHashCode(this.Payload);
			return hashCode;
		}

		/// <inheritdoc />
		public static bool operator ==(GraphQLSubscriptionRequest request1, GraphQLSubscriptionRequest request2) => EqualityComparer<GraphQLSubscriptionRequest>.Default.Equals(request1, request2);

		/// <inheritdoc />
		public static bool operator !=(GraphQLSubscriptionRequest request1, GraphQLSubscriptionRequest request2) => !(request1 == request2);

	}

}
