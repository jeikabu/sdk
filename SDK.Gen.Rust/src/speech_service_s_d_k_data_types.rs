// Autogenerated by Thrift Compiler (0.11.0)
// DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING

#![allow(unused_imports)]
#![allow(unused_extern_crates)]
#![cfg_attr(feature = "cargo-clippy", allow(too_many_arguments, type_complexity))]
#![cfg_attr(rustfmt, rustfmt_skip)]

extern crate ordered_float;
extern crate thrift;
extern crate try_from;

use ordered_float::OrderedFloat;
use std::cell::RefCell;
use std::collections::{BTreeMap, BTreeSet};
use std::convert::From;
use std::default::Default;
use std::error::Error;
use std::fmt;
use std::fmt::{Display, Formatter};
use std::rc::Rc;
use try_from::TryFrom;

use thrift::{ApplicationError, ApplicationErrorKind, ProtocolError, ProtocolErrorKind, TThriftClient};
use thrift::protocol::{TFieldIdentifier, TListIdentifier, TMapIdentifier, TMessageIdentifier, TMessageType, TInputProtocol, TOutputProtocol, TSetIdentifier, TStructIdentifier, TType};
use thrift::protocol::field_id;
use thrift::protocol::verify_expected_message_type;
use thrift::protocol::verify_expected_sequence_number;
use thrift::protocol::verify_expected_service_call;
use thrift::protocol::verify_required_field_exists;
use thrift::server::TProcessor;

#[derive(Copy, Clone, Debug, Eq, Hash, Ord, PartialEq, PartialOrd)]
pub enum SpeechResult {
  OK = 0,
  FAIL = 1,
}

impl SpeechResult {
  pub fn write_to_out_protocol(&self, o_prot: &mut TOutputProtocol) -> thrift::Result<()> {
    o_prot.write_i32(*self as i32)
  }
  pub fn read_from_in_protocol(i_prot: &mut TInputProtocol) -> thrift::Result<SpeechResult> {
    let enum_value = i_prot.read_i32()?;
    SpeechResult::try_from(enum_value)  }
}

impl TryFrom<i32> for SpeechResult {
  type Err = thrift::Error;  fn try_from(i: i32) -> Result<Self, Self::Err> {
    match i {
      0 => Ok(SpeechResult::OK),
      1 => Ok(SpeechResult::FAIL),
      _ => {
        Err(
          thrift::Error::Protocol(
            ProtocolError::new(
              ProtocolErrorKind::InvalidData,
              format!("cannot convert enum constant {} to SpeechResult", i)
            )
          )
        )
      },
    }
  }
}

//
// File
//

#[derive(Clone, Debug, Eq, Hash, Ord, PartialEq, PartialOrd)]
pub struct File {
  pub filename: Option<String>,
}

impl File {
  pub fn new<F1>(filename: F1) -> File where F1: Into<Option<String>> {
    File {
      filename: filename.into(),
    }
  }
  pub fn read_from_in_protocol(i_prot: &mut TInputProtocol) -> thrift::Result<File> {
    i_prot.read_struct_begin()?;
    let mut f_1: Option<String> = Some("".to_owned());
    loop {
      let field_ident = i_prot.read_field_begin()?;
      if field_ident.field_type == TType::Stop {
        break;
      }
      let field_id = field_id(&field_ident)?;
      match field_id {
        1 => {
          let val = i_prot.read_string()?;
          f_1 = Some(val);
        },
        _ => {
          i_prot.skip(field_ident.field_type)?;
        },
      };
      i_prot.read_field_end()?;
    }
    i_prot.read_struct_end()?;
    let ret = File {
      filename: f_1,
    };
    Ok(ret)
  }
  pub fn write_to_out_protocol(&self, o_prot: &mut TOutputProtocol) -> thrift::Result<()> {
    let struct_ident = TStructIdentifier::new("File");
    o_prot.write_struct_begin(&struct_ident)?;
    if let Some(ref fld_var) = self.filename {
      o_prot.write_field_begin(&TFieldIdentifier::new("filename", TType::String, 1))?;
      o_prot.write_string(fld_var)?;
      o_prot.write_field_end()?;
      ()
    } else {
      ()
    }
    o_prot.write_field_stop()?;
    o_prot.write_struct_end()
  }
}

impl Default for File {
  fn default() -> Self {
    File{
      filename: Some("".to_owned()),
    }
  }
}

//
// VoiceCommand
//

#[derive(Clone, Debug, Eq, Hash, Ord, PartialEq, PartialOrd)]
pub enum VoiceCommand {
  Filename(String),
  RawData(Vec<u8>),
}

impl VoiceCommand {
  pub fn read_from_in_protocol(i_prot: &mut TInputProtocol) -> thrift::Result<VoiceCommand> {
    let mut ret: Option<VoiceCommand> = None;
    let mut received_field_count = 0;
    i_prot.read_struct_begin()?;
    loop {
      let field_ident = i_prot.read_field_begin()?;
      if field_ident.field_type == TType::Stop {
        break;
      }
      let field_id = field_id(&field_ident)?;
      match field_id {
        1 => {
          let val = i_prot.read_string()?;
          if ret.is_none() {
            ret = Some(VoiceCommand::Filename(val));
          }
          received_field_count += 1;
        },
        2 => {
          let val = i_prot.read_bytes()?;
          if ret.is_none() {
            ret = Some(VoiceCommand::RawData(val));
          }
          received_field_count += 1;
        },
        _ => {
          i_prot.skip(field_ident.field_type)?;
          received_field_count += 1;
        },
      };
      i_prot.read_field_end()?;
    }
    i_prot.read_struct_end()?;
    if received_field_count == 0 {
      Err(
        thrift::Error::Protocol(
          ProtocolError::new(
            ProtocolErrorKind::InvalidData,
            "received empty union from remote VoiceCommand"
          )
        )
      )
    } else if received_field_count > 1 {
      Err(
        thrift::Error::Protocol(
          ProtocolError::new(
            ProtocolErrorKind::InvalidData,
            "received multiple fields for union from remote VoiceCommand"
          )
        )
      )
    } else {
      Ok(ret.expect("return value should have been constructed"))
    }
  }
  pub fn write_to_out_protocol(&self, o_prot: &mut TOutputProtocol) -> thrift::Result<()> {
    let struct_ident = TStructIdentifier::new("VoiceCommand");
    o_prot.write_struct_begin(&struct_ident)?;
    match *self {
      VoiceCommand::Filename(ref f) => {
        o_prot.write_field_begin(&TFieldIdentifier::new("Filename", TType::String, 1))?;
        o_prot.write_string(f)?;
        o_prot.write_field_end()?;
      },
      VoiceCommand::RawData(ref f) => {
        o_prot.write_field_begin(&TFieldIdentifier::new("RawData", TType::String, 2))?;
        o_prot.write_bytes(f)?;
        o_prot.write_field_end()?;
      },
    }
    o_prot.write_field_stop()?;
    o_prot.write_struct_end()
  }
}
