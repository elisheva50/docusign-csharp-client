using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace DocuSign.eSign.Model
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class AuthenticationStatus : IEquatable<AuthenticationStatus>
    {
        
        /// <summary>
        /// Gets or Sets AccessCodeResult
        /// </summary>
        [DataMember(Name="accessCodeResult", EmitDefaultValue=false)]
        public EventResult AccessCodeResult { get; set; }
  
        
        /// <summary>
        /// Gets or Sets PhoneAuthResult
        /// </summary>
        [DataMember(Name="phoneAuthResult", EmitDefaultValue=false)]
        public EventResult PhoneAuthResult { get; set; }
  
        
        /// <summary>
        /// Gets or Sets IdLookupResult
        /// </summary>
        [DataMember(Name="idLookupResult", EmitDefaultValue=false)]
        public EventResult IdLookupResult { get; set; }
  
        
        /// <summary>
        /// Gets or Sets IdQuestionsResult
        /// </summary>
        [DataMember(Name="idQuestionsResult", EmitDefaultValue=false)]
        public EventResult IdQuestionsResult { get; set; }
  
        
        /// <summary>
        /// Gets or Sets AgeVerifyResult
        /// </summary>
        [DataMember(Name="ageVerifyResult", EmitDefaultValue=false)]
        public EventResult AgeVerifyResult { get; set; }
  
        
        /// <summary>
        /// Gets or Sets STANPinResult
        /// </summary>
        [DataMember(Name="sTANPinResult", EmitDefaultValue=false)]
        public EventResult STANPinResult { get; set; }
  
        
        /// <summary>
        /// Gets or Sets OfacResult
        /// </summary>
        [DataMember(Name="ofacResult", EmitDefaultValue=false)]
        public EventResult OfacResult { get; set; }
  
        
        /// <summary>
        /// Gets or Sets LiveIDResult
        /// </summary>
        [DataMember(Name="liveIDResult", EmitDefaultValue=false)]
        public EventResult LiveIDResult { get; set; }
  
        
        /// <summary>
        /// Gets or Sets FacebookResult
        /// </summary>
        [DataMember(Name="facebookResult", EmitDefaultValue=false)]
        public EventResult FacebookResult { get; set; }
  
        
        /// <summary>
        /// Gets or Sets GoogleResult
        /// </summary>
        [DataMember(Name="googleResult", EmitDefaultValue=false)]
        public EventResult GoogleResult { get; set; }
  
        
        /// <summary>
        /// Gets or Sets LinkedinResult
        /// </summary>
        [DataMember(Name="linkedinResult", EmitDefaultValue=false)]
        public EventResult LinkedinResult { get; set; }
  
        
        /// <summary>
        /// Gets or Sets SalesforceResult
        /// </summary>
        [DataMember(Name="salesforceResult", EmitDefaultValue=false)]
        public EventResult SalesforceResult { get; set; }
  
        
        /// <summary>
        /// Gets or Sets TwitterResult
        /// </summary>
        [DataMember(Name="twitterResult", EmitDefaultValue=false)]
        public EventResult TwitterResult { get; set; }
  
        
        /// <summary>
        /// Gets or Sets OpenIDResult
        /// </summary>
        [DataMember(Name="openIDResult", EmitDefaultValue=false)]
        public EventResult OpenIDResult { get; set; }
  
        
        /// <summary>
        /// Gets or Sets AnySocialIDResult
        /// </summary>
        [DataMember(Name="anySocialIDResult", EmitDefaultValue=false)]
        public EventResult AnySocialIDResult { get; set; }
  
        
        /// <summary>
        /// Gets or Sets YahooResult
        /// </summary>
        [DataMember(Name="yahooResult", EmitDefaultValue=false)]
        public EventResult YahooResult { get; set; }
  
        
        /// <summary>
        /// Gets or Sets SmsAuthResult
        /// </summary>
        [DataMember(Name="smsAuthResult", EmitDefaultValue=false)]
        public EventResult SmsAuthResult { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuthenticationStatus {\n");
            sb.Append("  AccessCodeResult: ").Append(AccessCodeResult).Append("\n");
            sb.Append("  PhoneAuthResult: ").Append(PhoneAuthResult).Append("\n");
            sb.Append("  IdLookupResult: ").Append(IdLookupResult).Append("\n");
            sb.Append("  IdQuestionsResult: ").Append(IdQuestionsResult).Append("\n");
            sb.Append("  AgeVerifyResult: ").Append(AgeVerifyResult).Append("\n");
            sb.Append("  STANPinResult: ").Append(STANPinResult).Append("\n");
            sb.Append("  OfacResult: ").Append(OfacResult).Append("\n");
            sb.Append("  LiveIDResult: ").Append(LiveIDResult).Append("\n");
            sb.Append("  FacebookResult: ").Append(FacebookResult).Append("\n");
            sb.Append("  GoogleResult: ").Append(GoogleResult).Append("\n");
            sb.Append("  LinkedinResult: ").Append(LinkedinResult).Append("\n");
            sb.Append("  SalesforceResult: ").Append(SalesforceResult).Append("\n");
            sb.Append("  TwitterResult: ").Append(TwitterResult).Append("\n");
            sb.Append("  OpenIDResult: ").Append(OpenIDResult).Append("\n");
            sb.Append("  AnySocialIDResult: ").Append(AnySocialIDResult).Append("\n");
            sb.Append("  YahooResult: ").Append(YahooResult).Append("\n");
            sb.Append("  SmsAuthResult: ").Append(SmsAuthResult).Append("\n");
            
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as AuthenticationStatus);
        }

        /// <summary>
        /// Returns true if AuthenticationStatus instances are equal
        /// </summary>
        /// <param name="other">Instance of AuthenticationStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuthenticationStatus other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AccessCodeResult == other.AccessCodeResult ||
                    this.AccessCodeResult != null &&
                    this.AccessCodeResult.Equals(other.AccessCodeResult)
                ) && 
                (
                    this.PhoneAuthResult == other.PhoneAuthResult ||
                    this.PhoneAuthResult != null &&
                    this.PhoneAuthResult.Equals(other.PhoneAuthResult)
                ) && 
                (
                    this.IdLookupResult == other.IdLookupResult ||
                    this.IdLookupResult != null &&
                    this.IdLookupResult.Equals(other.IdLookupResult)
                ) && 
                (
                    this.IdQuestionsResult == other.IdQuestionsResult ||
                    this.IdQuestionsResult != null &&
                    this.IdQuestionsResult.Equals(other.IdQuestionsResult)
                ) && 
                (
                    this.AgeVerifyResult == other.AgeVerifyResult ||
                    this.AgeVerifyResult != null &&
                    this.AgeVerifyResult.Equals(other.AgeVerifyResult)
                ) && 
                (
                    this.STANPinResult == other.STANPinResult ||
                    this.STANPinResult != null &&
                    this.STANPinResult.Equals(other.STANPinResult)
                ) && 
                (
                    this.OfacResult == other.OfacResult ||
                    this.OfacResult != null &&
                    this.OfacResult.Equals(other.OfacResult)
                ) && 
                (
                    this.LiveIDResult == other.LiveIDResult ||
                    this.LiveIDResult != null &&
                    this.LiveIDResult.Equals(other.LiveIDResult)
                ) && 
                (
                    this.FacebookResult == other.FacebookResult ||
                    this.FacebookResult != null &&
                    this.FacebookResult.Equals(other.FacebookResult)
                ) && 
                (
                    this.GoogleResult == other.GoogleResult ||
                    this.GoogleResult != null &&
                    this.GoogleResult.Equals(other.GoogleResult)
                ) && 
                (
                    this.LinkedinResult == other.LinkedinResult ||
                    this.LinkedinResult != null &&
                    this.LinkedinResult.Equals(other.LinkedinResult)
                ) && 
                (
                    this.SalesforceResult == other.SalesforceResult ||
                    this.SalesforceResult != null &&
                    this.SalesforceResult.Equals(other.SalesforceResult)
                ) && 
                (
                    this.TwitterResult == other.TwitterResult ||
                    this.TwitterResult != null &&
                    this.TwitterResult.Equals(other.TwitterResult)
                ) && 
                (
                    this.OpenIDResult == other.OpenIDResult ||
                    this.OpenIDResult != null &&
                    this.OpenIDResult.Equals(other.OpenIDResult)
                ) && 
                (
                    this.AnySocialIDResult == other.AnySocialIDResult ||
                    this.AnySocialIDResult != null &&
                    this.AnySocialIDResult.Equals(other.AnySocialIDResult)
                ) && 
                (
                    this.YahooResult == other.YahooResult ||
                    this.YahooResult != null &&
                    this.YahooResult.Equals(other.YahooResult)
                ) && 
                (
                    this.SmsAuthResult == other.SmsAuthResult ||
                    this.SmsAuthResult != null &&
                    this.SmsAuthResult.Equals(other.SmsAuthResult)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                
                if (this.AccessCodeResult != null)
                    hash = hash * 57 + this.AccessCodeResult.GetHashCode();
                
                if (this.PhoneAuthResult != null)
                    hash = hash * 57 + this.PhoneAuthResult.GetHashCode();
                
                if (this.IdLookupResult != null)
                    hash = hash * 57 + this.IdLookupResult.GetHashCode();
                
                if (this.IdQuestionsResult != null)
                    hash = hash * 57 + this.IdQuestionsResult.GetHashCode();
                
                if (this.AgeVerifyResult != null)
                    hash = hash * 57 + this.AgeVerifyResult.GetHashCode();
                
                if (this.STANPinResult != null)
                    hash = hash * 57 + this.STANPinResult.GetHashCode();
                
                if (this.OfacResult != null)
                    hash = hash * 57 + this.OfacResult.GetHashCode();
                
                if (this.LiveIDResult != null)
                    hash = hash * 57 + this.LiveIDResult.GetHashCode();
                
                if (this.FacebookResult != null)
                    hash = hash * 57 + this.FacebookResult.GetHashCode();
                
                if (this.GoogleResult != null)
                    hash = hash * 57 + this.GoogleResult.GetHashCode();
                
                if (this.LinkedinResult != null)
                    hash = hash * 57 + this.LinkedinResult.GetHashCode();
                
                if (this.SalesforceResult != null)
                    hash = hash * 57 + this.SalesforceResult.GetHashCode();
                
                if (this.TwitterResult != null)
                    hash = hash * 57 + this.TwitterResult.GetHashCode();
                
                if (this.OpenIDResult != null)
                    hash = hash * 57 + this.OpenIDResult.GetHashCode();
                
                if (this.AnySocialIDResult != null)
                    hash = hash * 57 + this.AnySocialIDResult.GetHashCode();
                
                if (this.YahooResult != null)
                    hash = hash * 57 + this.YahooResult.GetHashCode();
                
                if (this.SmsAuthResult != null)
                    hash = hash * 57 + this.SmsAuthResult.GetHashCode();
                
                return hash;
            }
        }

    }
}
