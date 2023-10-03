<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="extraPack.aspx.cs" Inherits="monitor.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">   
   <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous">
        <%--<asp:Repeater ID="Repeater1" runat="server">--%>
   <div class="table-responsive">
       <%--asp:TextBox class="bg-white" ID="PageNumber" runat="server" ReadOnly="True"/>--%>
       <%-- stocké le numéro de la page --%>
        <asp:Repeater ID="Repeater1" runat="server">
            <HeaderTemplate> 
                <table class="mt-3 table table-striped table-hover " >
                    <thead >
                        <tr class="table-danger">
                            <th>Code de la tache</th>
                            <th>Date de Création</th>
                            <th>Etat de la demande</th> 
                            <th>Libelle</th>
                            <th>Nature de la Demande</th>
                            <th>Libelle Long</th>    
                            <th>Immatriculation</th> 
                            <th>Adresse Mail</th> 
                            <th>Ville du Sinistre</th> 
                         </tr>                      
                     </thead>
                    <tbody class="text-Dark">
            </HeaderTemplate>
              <ItemTemplate>
                    <tr>    <td>                 
                            <asp:Label ID="VehiculeImmat" runat="server" Text='<%# Eval("TAC_CODE ")%>'/>
                        </td>
                         <td>
                            <asp:Label ID="EntitieSinistre" runat="server" Text='<%# Eval("dateCreation")%>'/>
                        </td>
                         <td>
                           <asp:Label ID="CtrCode" runat="server" Text='<%# Eval("EtatDemande")%>'/>
                        </td>
                        <td>
                           <asp:Label ID="Client" runat="server" Text='<%# Eval("libelle")%>'/>
                        </td>
                         <td>
                           <asp:Label ID="EntitePolice" runat="server" Text='<%# Eval("NatureDemande")%>'/>
                        </td>
                         <td>
                            <asp:Label ID="EntiteVehicule" runat="server" Text='<%# Eval("libelleLong")%>'/>
                        </td>
                         <td>
                            <asp:Label ID="Label1" runat="server" Text='<%# Eval("Immatriculation")%>'/>
                        </td>
                         <td>
                            <asp:Label ID="Label2" runat="server" Text='<%# Eval("contactMail")%>'/>
                        </td>
                         <td>
                            <asp:Label ID="Label3" runat="server" Text='<%# Eval("sin_lieu_ville")%>'/>
                        </td>
                    </tr>
          </ItemTemplate>
          <FooterTemplate>
                </tbody>
           </table>
         </FooterTemplate>
        </asp:Repeater>
    </div>

    </main>
</asp:Content>
