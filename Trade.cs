// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ssigmaapi/type/trade.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Ssigmaapi.Type {

  /// <summary>Holder for reflection information generated from ssigmaapi/type/trade.proto</summary>
  public static partial class TradeReflection {

    #region Descriptor
    /// <summary>File descriptor for ssigmaapi/type/trade.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TradeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Chpzc2lnbWFhcGkvdHlwZS90cmFkZS5wcm90bxIOc3NpZ21hYXBpLnR5cGUi",
            "LwoGVHJhZGVzEiUKBnRyYWRlcxgBIAMoCzIVLnNzaWdtYWFwaS50eXBlLlRy",
            "YWRlIpgBCgVUcmFkZRIOCgZzeW1ib2wYASABKAkSEAoIdHJhZGVfaWQYAiAB",
            "KAkSEAoIZXhjaGFuZ2UYAyABKAkSDAoEYmFzZRgEIAEoCRINCgVxdW90ZRgF",
            "IAEoCRINCgVwcmljZRgGIAEoARIOCgZhbW91bnQYByABKAESEQoJdGltZXN0",
            "YW1wGAggASgDEgwKBHNpZGUYCSABKAlCMFouZ2l0aHViLmNvbS9rYWl0bzIv",
            "c3NpZ21hYXBpZ28vdHlwZS90cmFkZTt0cmFkZWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Ssigmaapi.Type.Trades), global::Ssigmaapi.Type.Trades.Parser, new[]{ "Trades_" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Ssigmaapi.Type.Trade), global::Ssigmaapi.Type.Trade.Parser, new[]{ "Symbol", "TradeId", "Exchange", "Base", "Quote", "Price", "Amount", "Timestamp", "Side" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Trades : pb::IMessage<Trades> {
    private static readonly pb::MessageParser<Trades> _parser = new pb::MessageParser<Trades>(() => new Trades());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Trades> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Ssigmaapi.Type.TradeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Trades() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Trades(Trades other) : this() {
      trades_ = other.trades_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Trades Clone() {
      return new Trades(this);
    }

    /// <summary>Field number for the "trades" field.</summary>
    public const int Trades_FieldNumber = 1;
    private static readonly pb::FieldCodec<global::Ssigmaapi.Type.Trade> _repeated_trades_codec
        = pb::FieldCodec.ForMessage(10, global::Ssigmaapi.Type.Trade.Parser);
    private readonly pbc::RepeatedField<global::Ssigmaapi.Type.Trade> trades_ = new pbc::RepeatedField<global::Ssigmaapi.Type.Trade>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Ssigmaapi.Type.Trade> Trades_ {
      get { return trades_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Trades);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Trades other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!trades_.Equals(other.trades_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= trades_.GetHashCode();
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
      trades_.WriteTo(output, _repeated_trades_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += trades_.CalculateSize(_repeated_trades_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Trades other) {
      if (other == null) {
        return;
      }
      trades_.Add(other.trades_);
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
            trades_.AddEntriesFrom(input, _repeated_trades_codec);
            break;
          }
        }
      }
    }

  }

  public sealed partial class Trade : pb::IMessage<Trade> {
    private static readonly pb::MessageParser<Trade> _parser = new pb::MessageParser<Trade>(() => new Trade());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Trade> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Ssigmaapi.Type.TradeReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Trade() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Trade(Trade other) : this() {
      symbol_ = other.symbol_;
      tradeId_ = other.tradeId_;
      exchange_ = other.exchange_;
      base_ = other.base_;
      quote_ = other.quote_;
      price_ = other.price_;
      amount_ = other.amount_;
      timestamp_ = other.timestamp_;
      side_ = other.side_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Trade Clone() {
      return new Trade(this);
    }

    /// <summary>Field number for the "symbol" field.</summary>
    public const int SymbolFieldNumber = 1;
    private string symbol_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Symbol {
      get { return symbol_; }
      set {
        symbol_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "trade_id" field.</summary>
    public const int TradeIdFieldNumber = 2;
    private string tradeId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string TradeId {
      get { return tradeId_; }
      set {
        tradeId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "exchange" field.</summary>
    public const int ExchangeFieldNumber = 3;
    private string exchange_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Exchange {
      get { return exchange_; }
      set {
        exchange_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "base" field.</summary>
    public const int BaseFieldNumber = 4;
    private string base_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Base {
      get { return base_; }
      set {
        base_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "quote" field.</summary>
    public const int QuoteFieldNumber = 5;
    private string quote_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Quote {
      get { return quote_; }
      set {
        quote_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "price" field.</summary>
    public const int PriceFieldNumber = 6;
    private double price_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double Price {
      get { return price_; }
      set {
        price_ = value;
      }
    }

    /// <summary>Field number for the "amount" field.</summary>
    public const int AmountFieldNumber = 7;
    private double amount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double Amount {
      get { return amount_; }
      set {
        amount_ = value;
      }
    }

    /// <summary>Field number for the "timestamp" field.</summary>
    public const int TimestampFieldNumber = 8;
    private long timestamp_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long Timestamp {
      get { return timestamp_; }
      set {
        timestamp_ = value;
      }
    }

    /// <summary>Field number for the "side" field.</summary>
    public const int SideFieldNumber = 9;
    private string side_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Side {
      get { return side_; }
      set {
        side_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Trade);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Trade other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Symbol != other.Symbol) return false;
      if (TradeId != other.TradeId) return false;
      if (Exchange != other.Exchange) return false;
      if (Base != other.Base) return false;
      if (Quote != other.Quote) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Price, other.Price)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Amount, other.Amount)) return false;
      if (Timestamp != other.Timestamp) return false;
      if (Side != other.Side) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Symbol.Length != 0) hash ^= Symbol.GetHashCode();
      if (TradeId.Length != 0) hash ^= TradeId.GetHashCode();
      if (Exchange.Length != 0) hash ^= Exchange.GetHashCode();
      if (Base.Length != 0) hash ^= Base.GetHashCode();
      if (Quote.Length != 0) hash ^= Quote.GetHashCode();
      if (Price != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Price);
      if (Amount != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Amount);
      if (Timestamp != 0L) hash ^= Timestamp.GetHashCode();
      if (Side.Length != 0) hash ^= Side.GetHashCode();
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
      if (Symbol.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Symbol);
      }
      if (TradeId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(TradeId);
      }
      if (Exchange.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Exchange);
      }
      if (Base.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Base);
      }
      if (Quote.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Quote);
      }
      if (Price != 0D) {
        output.WriteRawTag(49);
        output.WriteDouble(Price);
      }
      if (Amount != 0D) {
        output.WriteRawTag(57);
        output.WriteDouble(Amount);
      }
      if (Timestamp != 0L) {
        output.WriteRawTag(64);
        output.WriteInt64(Timestamp);
      }
      if (Side.Length != 0) {
        output.WriteRawTag(74);
        output.WriteString(Side);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Symbol.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Symbol);
      }
      if (TradeId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(TradeId);
      }
      if (Exchange.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Exchange);
      }
      if (Base.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Base);
      }
      if (Quote.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Quote);
      }
      if (Price != 0D) {
        size += 1 + 8;
      }
      if (Amount != 0D) {
        size += 1 + 8;
      }
      if (Timestamp != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Timestamp);
      }
      if (Side.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Side);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Trade other) {
      if (other == null) {
        return;
      }
      if (other.Symbol.Length != 0) {
        Symbol = other.Symbol;
      }
      if (other.TradeId.Length != 0) {
        TradeId = other.TradeId;
      }
      if (other.Exchange.Length != 0) {
        Exchange = other.Exchange;
      }
      if (other.Base.Length != 0) {
        Base = other.Base;
      }
      if (other.Quote.Length != 0) {
        Quote = other.Quote;
      }
      if (other.Price != 0D) {
        Price = other.Price;
      }
      if (other.Amount != 0D) {
        Amount = other.Amount;
      }
      if (other.Timestamp != 0L) {
        Timestamp = other.Timestamp;
      }
      if (other.Side.Length != 0) {
        Side = other.Side;
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
            Symbol = input.ReadString();
            break;
          }
          case 18: {
            TradeId = input.ReadString();
            break;
          }
          case 26: {
            Exchange = input.ReadString();
            break;
          }
          case 34: {
            Base = input.ReadString();
            break;
          }
          case 42: {
            Quote = input.ReadString();
            break;
          }
          case 49: {
            Price = input.ReadDouble();
            break;
          }
          case 57: {
            Amount = input.ReadDouble();
            break;
          }
          case 64: {
            Timestamp = input.ReadInt64();
            break;
          }
          case 74: {
            Side = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
