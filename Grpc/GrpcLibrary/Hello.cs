// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Hello.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace GrpcLibrary {

  /// <summary>Holder for reflection information generated from Hello.proto</summary>
  public static partial class HelloReflection {

    #region Descriptor
    /// <summary>File descriptor for Hello.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HelloReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CgtIZWxsby5wcm90bxILR3JwY0xpYnJhcnkiLgoQR2V0TXNnTnVtUmVxdWVz",
            "dBIMCgROdW0xGAEgASgFEgwKBE51bTIYAiABKAUiHQoOR2V0TXNnU3VtUmVw",
            "bHkSCwoDU3VtGAEgASgFIiMKCEdldExvdElEEgwKBE51bTEYASABKAUSCQoB",
            "cxgCIAEoCSKGAQoJR2V0TG90QWxsEicKAXQYASABKA4yHC5HcnBjTGlicmFy",
            "eS5HZXRMb3RBbGwuTGlzdHMSIwoEdXNlchgCIAMoCzIVLkdycGNMaWJyYXJ5",
            "LlVzZXJMaXN0IisKBUxpc3RzEgcKA21lcxAAEgcKA3dpcBABEgcKA2VhcBAC",
            "EgcKA2RjcxADIikKCFVzZXJMaXN0EhAKCHVzZXJOYW1lGAEgASgJEgsKA3B3",
            "ZBgCIAEoCSIqCgxHZXRNZWdOdW1NdWwSDAoETnVtMRgBIAEoBRIMCgROdW0y",
            "GAIgASgFIiAKEUdldE1lZ051bU11bFJlcGx5EgsKA011bBgBIAEoBTLWAQoM",
            "SGVsbG9TZXJ2aWNlEkYKBkdldFN1bRIdLkdycGNMaWJyYXJ5LkdldE1zZ051",
            "bVJlcXVlc3QaGy5HcnBjTGlicmFyeS5HZXRNc2dTdW1SZXBseSIAEjcKBHRl",
            "c3QSFS5HcnBjTGlicmFyeS5HZXRMb3RJRBoWLkdycGNMaWJyYXJ5LkdldExv",
            "dEFsbCIAEkUKBkdldE11bBIZLkdycGNMaWJyYXJ5LkdldE1lZ051bU11bBoe",
            "LkdycGNMaWJyYXJ5LkdldE1lZ051bU11bFJlcGx5IgBiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::GrpcLibrary.GetMsgNumRequest), global::GrpcLibrary.GetMsgNumRequest.Parser, new[]{ "Num1", "Num2" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GrpcLibrary.GetMsgSumReply), global::GrpcLibrary.GetMsgSumReply.Parser, new[]{ "Sum" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GrpcLibrary.GetLotID), global::GrpcLibrary.GetLotID.Parser, new[]{ "Num1", "S" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GrpcLibrary.GetLotAll), global::GrpcLibrary.GetLotAll.Parser, new[]{ "T", "User" }, null, new[]{ typeof(global::GrpcLibrary.GetLotAll.Types.Lists) }, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GrpcLibrary.UserList), global::GrpcLibrary.UserList.Parser, new[]{ "UserName", "Pwd" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GrpcLibrary.GetMegNumMul), global::GrpcLibrary.GetMegNumMul.Parser, new[]{ "Num1", "Num2" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GrpcLibrary.GetMegNumMulReply), global::GrpcLibrary.GetMegNumMulReply.Parser, new[]{ "Mul" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GetMsgNumRequest : pb::IMessage<GetMsgNumRequest> {
    private static readonly pb::MessageParser<GetMsgNumRequest> _parser = new pb::MessageParser<GetMsgNumRequest>(() => new GetMsgNumRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetMsgNumRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GrpcLibrary.HelloReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetMsgNumRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetMsgNumRequest(GetMsgNumRequest other) : this() {
      num1_ = other.num1_;
      num2_ = other.num2_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetMsgNumRequest Clone() {
      return new GetMsgNumRequest(this);
    }

    /// <summary>Field number for the "Num1" field.</summary>
    public const int Num1FieldNumber = 1;
    private int num1_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Num1 {
      get { return num1_; }
      set {
        num1_ = value;
      }
    }

    /// <summary>Field number for the "Num2" field.</summary>
    public const int Num2FieldNumber = 2;
    private int num2_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Num2 {
      get { return num2_; }
      set {
        num2_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetMsgNumRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetMsgNumRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Num1 != other.Num1) return false;
      if (Num2 != other.Num2) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Num1 != 0) hash ^= Num1.GetHashCode();
      if (Num2 != 0) hash ^= Num2.GetHashCode();
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
      if (Num1 != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Num1);
      }
      if (Num2 != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Num2);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Num1 != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Num1);
      }
      if (Num2 != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Num2);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetMsgNumRequest other) {
      if (other == null) {
        return;
      }
      if (other.Num1 != 0) {
        Num1 = other.Num1;
      }
      if (other.Num2 != 0) {
        Num2 = other.Num2;
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
          case 8: {
            Num1 = input.ReadInt32();
            break;
          }
          case 16: {
            Num2 = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  public sealed partial class GetMsgSumReply : pb::IMessage<GetMsgSumReply> {
    private static readonly pb::MessageParser<GetMsgSumReply> _parser = new pb::MessageParser<GetMsgSumReply>(() => new GetMsgSumReply());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetMsgSumReply> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GrpcLibrary.HelloReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetMsgSumReply() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetMsgSumReply(GetMsgSumReply other) : this() {
      sum_ = other.sum_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetMsgSumReply Clone() {
      return new GetMsgSumReply(this);
    }

    /// <summary>Field number for the "Sum" field.</summary>
    public const int SumFieldNumber = 1;
    private int sum_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Sum {
      get { return sum_; }
      set {
        sum_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetMsgSumReply);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetMsgSumReply other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Sum != other.Sum) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Sum != 0) hash ^= Sum.GetHashCode();
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
      if (Sum != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Sum);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Sum != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Sum);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetMsgSumReply other) {
      if (other == null) {
        return;
      }
      if (other.Sum != 0) {
        Sum = other.Sum;
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
          case 8: {
            Sum = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  public sealed partial class GetLotID : pb::IMessage<GetLotID> {
    private static readonly pb::MessageParser<GetLotID> _parser = new pb::MessageParser<GetLotID>(() => new GetLotID());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetLotID> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GrpcLibrary.HelloReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetLotID() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetLotID(GetLotID other) : this() {
      num1_ = other.num1_;
      s_ = other.s_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetLotID Clone() {
      return new GetLotID(this);
    }

    /// <summary>Field number for the "Num1" field.</summary>
    public const int Num1FieldNumber = 1;
    private int num1_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Num1 {
      get { return num1_; }
      set {
        num1_ = value;
      }
    }

    /// <summary>Field number for the "s" field.</summary>
    public const int SFieldNumber = 2;
    private string s_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string S {
      get { return s_; }
      set {
        s_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetLotID);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetLotID other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Num1 != other.Num1) return false;
      if (S != other.S) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Num1 != 0) hash ^= Num1.GetHashCode();
      if (S.Length != 0) hash ^= S.GetHashCode();
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
      if (Num1 != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Num1);
      }
      if (S.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(S);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Num1 != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Num1);
      }
      if (S.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(S);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetLotID other) {
      if (other == null) {
        return;
      }
      if (other.Num1 != 0) {
        Num1 = other.Num1;
      }
      if (other.S.Length != 0) {
        S = other.S;
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
          case 8: {
            Num1 = input.ReadInt32();
            break;
          }
          case 18: {
            S = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class GetLotAll : pb::IMessage<GetLotAll> {
    private static readonly pb::MessageParser<GetLotAll> _parser = new pb::MessageParser<GetLotAll>(() => new GetLotAll());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetLotAll> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GrpcLibrary.HelloReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetLotAll() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetLotAll(GetLotAll other) : this() {
      t_ = other.t_;
      user_ = other.user_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetLotAll Clone() {
      return new GetLotAll(this);
    }

    /// <summary>Field number for the "t" field.</summary>
    public const int TFieldNumber = 1;
    private global::GrpcLibrary.GetLotAll.Types.Lists t_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::GrpcLibrary.GetLotAll.Types.Lists T {
      get { return t_; }
      set {
        t_ = value;
      }
    }

    /// <summary>Field number for the "user" field.</summary>
    public const int UserFieldNumber = 2;
    private static readonly pb::FieldCodec<global::GrpcLibrary.UserList> _repeated_user_codec
        = pb::FieldCodec.ForMessage(18, global::GrpcLibrary.UserList.Parser);
    private readonly pbc::RepeatedField<global::GrpcLibrary.UserList> user_ = new pbc::RepeatedField<global::GrpcLibrary.UserList>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::GrpcLibrary.UserList> User {
      get { return user_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetLotAll);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetLotAll other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (T != other.T) return false;
      if(!user_.Equals(other.user_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (T != 0) hash ^= T.GetHashCode();
      hash ^= user_.GetHashCode();
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
      if (T != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) T);
      }
      user_.WriteTo(output, _repeated_user_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (T != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) T);
      }
      size += user_.CalculateSize(_repeated_user_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetLotAll other) {
      if (other == null) {
        return;
      }
      if (other.T != 0) {
        T = other.T;
      }
      user_.Add(other.user_);
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
          case 8: {
            T = (global::GrpcLibrary.GetLotAll.Types.Lists) input.ReadEnum();
            break;
          }
          case 18: {
            user_.AddEntriesFrom(input, _repeated_user_codec);
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the GetLotAll message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum Lists {
        [pbr::OriginalName("mes")] Mes = 0,
        [pbr::OriginalName("wip")] Wip = 1,
        [pbr::OriginalName("eap")] Eap = 2,
        [pbr::OriginalName("dcs")] Dcs = 3,
      }

    }
    #endregion

  }

  public sealed partial class UserList : pb::IMessage<UserList> {
    private static readonly pb::MessageParser<UserList> _parser = new pb::MessageParser<UserList>(() => new UserList());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<UserList> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GrpcLibrary.HelloReflection.Descriptor.MessageTypes[4]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UserList() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UserList(UserList other) : this() {
      userName_ = other.userName_;
      pwd_ = other.pwd_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UserList Clone() {
      return new UserList(this);
    }

    /// <summary>Field number for the "userName" field.</summary>
    public const int UserNameFieldNumber = 1;
    private string userName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string UserName {
      get { return userName_; }
      set {
        userName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "pwd" field.</summary>
    public const int PwdFieldNumber = 2;
    private string pwd_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Pwd {
      get { return pwd_; }
      set {
        pwd_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as UserList);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(UserList other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (UserName != other.UserName) return false;
      if (Pwd != other.Pwd) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (UserName.Length != 0) hash ^= UserName.GetHashCode();
      if (Pwd.Length != 0) hash ^= Pwd.GetHashCode();
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
      if (UserName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(UserName);
      }
      if (Pwd.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Pwd);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (UserName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(UserName);
      }
      if (Pwd.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Pwd);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(UserList other) {
      if (other == null) {
        return;
      }
      if (other.UserName.Length != 0) {
        UserName = other.UserName;
      }
      if (other.Pwd.Length != 0) {
        Pwd = other.Pwd;
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
            UserName = input.ReadString();
            break;
          }
          case 18: {
            Pwd = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class GetMegNumMul : pb::IMessage<GetMegNumMul> {
    private static readonly pb::MessageParser<GetMegNumMul> _parser = new pb::MessageParser<GetMegNumMul>(() => new GetMegNumMul());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetMegNumMul> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GrpcLibrary.HelloReflection.Descriptor.MessageTypes[5]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetMegNumMul() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetMegNumMul(GetMegNumMul other) : this() {
      num1_ = other.num1_;
      num2_ = other.num2_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetMegNumMul Clone() {
      return new GetMegNumMul(this);
    }

    /// <summary>Field number for the "Num1" field.</summary>
    public const int Num1FieldNumber = 1;
    private int num1_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Num1 {
      get { return num1_; }
      set {
        num1_ = value;
      }
    }

    /// <summary>Field number for the "Num2" field.</summary>
    public const int Num2FieldNumber = 2;
    private int num2_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Num2 {
      get { return num2_; }
      set {
        num2_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetMegNumMul);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetMegNumMul other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Num1 != other.Num1) return false;
      if (Num2 != other.Num2) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Num1 != 0) hash ^= Num1.GetHashCode();
      if (Num2 != 0) hash ^= Num2.GetHashCode();
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
      if (Num1 != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Num1);
      }
      if (Num2 != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Num2);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Num1 != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Num1);
      }
      if (Num2 != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Num2);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetMegNumMul other) {
      if (other == null) {
        return;
      }
      if (other.Num1 != 0) {
        Num1 = other.Num1;
      }
      if (other.Num2 != 0) {
        Num2 = other.Num2;
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
          case 8: {
            Num1 = input.ReadInt32();
            break;
          }
          case 16: {
            Num2 = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  public sealed partial class GetMegNumMulReply : pb::IMessage<GetMegNumMulReply> {
    private static readonly pb::MessageParser<GetMegNumMulReply> _parser = new pb::MessageParser<GetMegNumMulReply>(() => new GetMegNumMulReply());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetMegNumMulReply> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GrpcLibrary.HelloReflection.Descriptor.MessageTypes[6]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetMegNumMulReply() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetMegNumMulReply(GetMegNumMulReply other) : this() {
      mul_ = other.mul_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetMegNumMulReply Clone() {
      return new GetMegNumMulReply(this);
    }

    /// <summary>Field number for the "Mul" field.</summary>
    public const int MulFieldNumber = 1;
    private int mul_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Mul {
      get { return mul_; }
      set {
        mul_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetMegNumMulReply);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetMegNumMulReply other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Mul != other.Mul) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Mul != 0) hash ^= Mul.GetHashCode();
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
      if (Mul != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Mul);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Mul != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Mul);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetMegNumMulReply other) {
      if (other == null) {
        return;
      }
      if (other.Mul != 0) {
        Mul = other.Mul;
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
          case 8: {
            Mul = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
