// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ServiceLinker.Models
{
    /// <summary> The authentication type. </summary>
    public readonly partial struct AuthType : IEquatable<AuthType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AuthType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AuthType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SystemAssignedIdentityValue = "systemAssignedIdentity";
        private const string UserAssignedIdentityValue = "userAssignedIdentity";
        private const string ServicePrincipalSecretValue = "servicePrincipalSecret";
        private const string ServicePrincipalCertificateValue = "servicePrincipalCertificate";
        private const string SecretValue = "secret";

        /// <summary> systemAssignedIdentity. </summary>
        public static AuthType SystemAssignedIdentity { get; } = new AuthType(SystemAssignedIdentityValue);
        /// <summary> userAssignedIdentity. </summary>
        public static AuthType UserAssignedIdentity { get; } = new AuthType(UserAssignedIdentityValue);
        /// <summary> servicePrincipalSecret. </summary>
        public static AuthType ServicePrincipalSecret { get; } = new AuthType(ServicePrincipalSecretValue);
        /// <summary> servicePrincipalCertificate. </summary>
        public static AuthType ServicePrincipalCertificate { get; } = new AuthType(ServicePrincipalCertificateValue);
        /// <summary> secret. </summary>
        public static AuthType Secret { get; } = new AuthType(SecretValue);
        /// <summary> Determines if two <see cref="AuthType"/> values are the same. </summary>
        public static bool operator ==(AuthType left, AuthType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AuthType"/> values are not the same. </summary>
        public static bool operator !=(AuthType left, AuthType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AuthType"/>. </summary>
        public static implicit operator AuthType(string value) => new AuthType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AuthType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AuthType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
