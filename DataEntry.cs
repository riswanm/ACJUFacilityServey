using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ACJUFacilityServey.Data;

namespace ACJUFacilityServey
{
    public partial class DataEntry : Form
    {
        public int applicantID;
        public DataEntry()
        {
            InitializeComponent();
        }


        private ApplicantModel CreateApplicantModelFromUI()
        {
            try
            {
                ApplicantModel retVal = new ApplicantModel();

                Applicant applicant = new Applicant();
                applicant.ID = applicantID;
                applicant.Address = Util.GetTextBoxValue(txtAddress);
                applicant.ContactNo = Util.GetTextBoxValue(txtContact);
                applicant.Email = Util.GetTextBoxValue(txtEmail);
                applicant.GS = Util.GetTextBoxValue(txtGs);

                applicant.Vehicle = Util.GetTextBoxValue(txtVehicleDetail);
                applicant.VehicleStatus = rbnVehOwn.Checked ? 1 : 2;
                if (rbnEcoA.Checked)
                {
                    applicant.EconomicStatus = 1;
                }
                else if (rbnEcoB.Checked)
                {
                    applicant.EconomicStatus = 2;
                }

                else if (rbnEcoC.Checked)
                {
                    applicant.EconomicStatus = 3;
                }
                else if (rbnEcoD.Checked)
                {
                    applicant.EconomicStatus = 4;
                }
                else if (rbnEcoE.Checked)
                {
                    applicant.EconomicStatus = 5;
                }

                applicant.EconomicRemarks = Util.GetTextBoxValue(txtEconomyRemark);
                applicant.NetIncome = Util.GetTextBoxValue(txtEconomyIncome);
                retVal.Applicant = applicant;

                HouseDetail houseDetail = new HouseDetail();
                houseDetail.ApplicantID = applicantID;
                houseDetail.OwnerShip = int.Parse(cmbOwnerShip.SelectedValue.ToString());
                houseDetail.OwnerShipOther = Util.GetTextBoxValue(txtOwnershipOther);
                houseDetail.Type = int.Parse(cmbHouseType.SelectedValue.ToString());
                if (!string.IsNullOrEmpty(txtHouseSize.Text.Trim()))
                {
                    houseDetail.SizeInPerch = decimal.Parse(txtHouseSize.Text.Trim());
                }
                if (!string.IsNullOrEmpty(txtNoOfFamily.Text.Trim()))
                {
                    houseDetail.NoOfFamiliyLiving = int.Parse(txtNoOfFamily.Text.Trim());
                }

                houseDetail.IsElectricity = chkElectricity.Checked;
                houseDetail.IsWaterSupply = chkWaterSupp.Checked;
                houseDetail.IsToilet = chkToilet.Checked;
                houseDetail.IsBathRoom = chkBathRoom.Checked;
                houseDetail.IStelephone = chkTel.Checked;
                houseDetail.FacilityRemark = Util.GetTextBoxValue(txtFacilityRemarks);
                retVal.HouseDetail = houseDetail;

                HelpFromGovernment helpFromGovernment = new HelpFromGovernment();
                helpFromGovernment.ApplicantID = applicantID;
                helpFromGovernment.Pension = Util.GetTextBoxValue(txtHelpFromPension);
                helpFromGovernment.PregnencyFund = Util.GetTextBoxValue(txtHelpFromPreg);
                helpFromGovernment.VeteronID = Util.GetTextBoxValue(txtHelpFromVet);
                helpFromGovernment.ReligiousScholar = Util.GetTextBoxValue(txtHelpFromrelSchol);
                helpFromGovernment.SchorlarShip = Util.GetTextBoxValue(txtHelpFromShol);
                retVal.HelpFromGovernment = helpFromGovernment;

                HelpsNeeded helpsNeeded = new HelpsNeeded();
                helpsNeeded.ApplicantID = applicantID;
                helpsNeeded.HigherStudies = 



                return retVal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

         
    }
}
