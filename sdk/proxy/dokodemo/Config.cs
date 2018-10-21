// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: v2ray.com/core/proxy/dokodemo/config.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace V2Ray.Core.Proxy.Dokodemo {

  /// <summary>Holder for reflection information generated from v2ray.com/core/proxy/dokodemo/config.proto</summary>
  public static partial class ConfigReflection {

    #region Descriptor
    /// <summary>File descriptor for v2ray.com/core/proxy/dokodemo/config.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ConfigReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cip2MnJheS5jb20vY29yZS9wcm94eS9kb2tvZGVtby9jb25maWcucHJvdG8S",
            "GXYycmF5LmNvcmUucHJveHkuZG9rb2RlbW8aJ3YycmF5LmNvbS9jb3JlL2Nv",
            "bW1vbi9uZXQvYWRkcmVzcy5wcm90bxondjJyYXkuY29tL2NvcmUvY29tbW9u",
            "L25ldC9uZXR3b3JrLnByb3RvIsYBCgZDb25maWcSMgoHYWRkcmVzcxgBIAEo",
            "CzIhLnYycmF5LmNvcmUuY29tbW9uLm5ldC5JUE9yRG9tYWluEgwKBHBvcnQY",
            "AiABKA0SOAoMbmV0d29ya19saXN0GAMgASgLMiIudjJyYXkuY29yZS5jb21t",
            "b24ubmV0Lk5ldHdvcmtMaXN0EhMKB3RpbWVvdXQYBCABKA1CAhgBEhcKD2Zv",
            "bGxvd19yZWRpcmVjdBgFIAEoCBISCgp1c2VyX2xldmVsGAYgASgNQkcKHWNv",
            "bS52MnJheS5jb3JlLnByb3h5LmRva29kZW1vUAFaCGRva29kZW1vqgIZVjJS",
            "YXkuQ29yZS5Qcm94eS5Eb2tvZGVtb2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::V2Ray.Core.Common.Net.AddressReflection.Descriptor, global::V2Ray.Core.Common.Net.NetworkReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::V2Ray.Core.Proxy.Dokodemo.Config), global::V2Ray.Core.Proxy.Dokodemo.Config.Parser, new[]{ "Address", "Port", "NetworkList", "Timeout", "FollowRedirect", "UserLevel" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Config : pb::IMessage<Config> {
    private static readonly pb::MessageParser<Config> _parser = new pb::MessageParser<Config>(() => new Config());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Config> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::V2Ray.Core.Proxy.Dokodemo.ConfigReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Config() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Config(Config other) : this() {
      address_ = other.address_ != null ? other.address_.Clone() : null;
      port_ = other.port_;
      networkList_ = other.networkList_ != null ? other.networkList_.Clone() : null;
      timeout_ = other.timeout_;
      followRedirect_ = other.followRedirect_;
      userLevel_ = other.userLevel_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Config Clone() {
      return new Config(this);
    }

    /// <summary>Field number for the "address" field.</summary>
    public const int AddressFieldNumber = 1;
    private global::V2Ray.Core.Common.Net.IPOrDomain address_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::V2Ray.Core.Common.Net.IPOrDomain Address {
      get { return address_; }
      set {
        address_ = value;
      }
    }

    /// <summary>Field number for the "port" field.</summary>
    public const int PortFieldNumber = 2;
    private uint port_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint Port {
      get { return port_; }
      set {
        port_ = value;
      }
    }

    /// <summary>Field number for the "network_list" field.</summary>
    public const int NetworkListFieldNumber = 3;
    private global::V2Ray.Core.Common.Net.NetworkList networkList_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::V2Ray.Core.Common.Net.NetworkList NetworkList {
      get { return networkList_; }
      set {
        networkList_ = value;
      }
    }

    /// <summary>Field number for the "timeout" field.</summary>
    public const int TimeoutFieldNumber = 4;
    private uint timeout_;
    [global::System.ObsoleteAttribute]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint Timeout {
      get { return timeout_; }
      set {
        timeout_ = value;
      }
    }

    /// <summary>Field number for the "follow_redirect" field.</summary>
    public const int FollowRedirectFieldNumber = 5;
    private bool followRedirect_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool FollowRedirect {
      get { return followRedirect_; }
      set {
        followRedirect_ = value;
      }
    }

    /// <summary>Field number for the "user_level" field.</summary>
    public const int UserLevelFieldNumber = 6;
    private uint userLevel_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint UserLevel {
      get { return userLevel_; }
      set {
        userLevel_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Config);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Config other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Address, other.Address)) return false;
      if (Port != other.Port) return false;
      if (!object.Equals(NetworkList, other.NetworkList)) return false;
      if (Timeout != other.Timeout) return false;
      if (FollowRedirect != other.FollowRedirect) return false;
      if (UserLevel != other.UserLevel) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (address_ != null) hash ^= Address.GetHashCode();
      if (Port != 0) hash ^= Port.GetHashCode();
      if (networkList_ != null) hash ^= NetworkList.GetHashCode();
      if (Timeout != 0) hash ^= Timeout.GetHashCode();
      if (FollowRedirect != false) hash ^= FollowRedirect.GetHashCode();
      if (UserLevel != 0) hash ^= UserLevel.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (address_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Address);
      }
      if (Port != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Port);
      }
      if (networkList_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(NetworkList);
      }
      if (Timeout != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Timeout);
      }
      if (FollowRedirect != false) {
        output.WriteRawTag(40);
        output.WriteBool(FollowRedirect);
      }
      if (UserLevel != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(UserLevel);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (address_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Address);
      }
      if (Port != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Port);
      }
      if (networkList_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(NetworkList);
      }
      if (Timeout != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Timeout);
      }
      if (FollowRedirect != false) {
        size += 1 + 1;
      }
      if (UserLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(UserLevel);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Config other) {
      if (other == null) {
        return;
      }
      if (other.address_ != null) {
        if (address_ == null) {
          address_ = new global::V2Ray.Core.Common.Net.IPOrDomain();
        }
        Address.MergeFrom(other.Address);
      }
      if (other.Port != 0) {
        Port = other.Port;
      }
      if (other.networkList_ != null) {
        if (networkList_ == null) {
          networkList_ = new global::V2Ray.Core.Common.Net.NetworkList();
        }
        NetworkList.MergeFrom(other.NetworkList);
      }
      if (other.Timeout != 0) {
        Timeout = other.Timeout;
      }
      if (other.FollowRedirect != false) {
        FollowRedirect = other.FollowRedirect;
      }
      if (other.UserLevel != 0) {
        UserLevel = other.UserLevel;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            if (address_ == null) {
              address_ = new global::V2Ray.Core.Common.Net.IPOrDomain();
            }
            input.ReadMessage(address_);
            break;
          }
          case 16: {
            Port = input.ReadUInt32();
            break;
          }
          case 26: {
            if (networkList_ == null) {
              networkList_ = new global::V2Ray.Core.Common.Net.NetworkList();
            }
            input.ReadMessage(networkList_);
            break;
          }
          case 32: {
            Timeout = input.ReadUInt32();
            break;
          }
          case 40: {
            FollowRedirect = input.ReadBool();
            break;
          }
          case 48: {
            UserLevel = input.ReadUInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code