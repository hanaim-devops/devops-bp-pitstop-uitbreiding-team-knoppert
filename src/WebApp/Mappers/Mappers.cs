namespace Pitstop.WebApp.Mappers;

public static class Mappers
{
    public static RegisterCustomer MapToRegisterCustomer(this CustomerManagementNewViewModel source) => new RegisterCustomer
    (
        Guid.NewGuid(),
        Guid.NewGuid().ToString("N"),
        source.Customer.Name,
        source.Customer.Address,
        source.Customer.PostalCode,
        source.Customer.City,
        source.Customer.TelephoneNumber,
        source.Customer.EmailAddress
    );

    public static RegisterVehicle MapToRegisterVehicle(this VehicleManagementNewViewModel source) => new RegisterVehicle(
        Guid.NewGuid(),
        source.Vehicle.LicenseNumber,
        source.Vehicle.Brand,
        source.Vehicle.Type,
        source.SelectedCustomerId
    );

    public static RegisterDIYRegistration MapToDIYRegistration(this DIYManagementNewRegistrationViewModel source) => new RegisterDIYRegistration(
        Guid.NewGuid(),
        source.DIYRegistration.DIYEveningId,
        source.DIYRegistration.CustomerName,
        source.DIYRegistration.Reparations
    );

    public static RegisterDIYEvening MapToRegisterEvening(this DIYNewViewModel source) => new RegisterDIYEvening(
        Guid.NewGuid(),
        source.DIYEvening.Title,
        source.DIYEvening.ExtraInfo,
        source.DIYEvening.StartDate,
        source.DIYEvening.EndDate,
        source.DIYEvening.Mechanic
    );
    
    public static RegisterDIYFeedback MapToDIYFeedback(this DIYManagementNewFeedbackViewModel source) => new RegisterDIYFeedback(
        Guid.NewGuid(),
        source.DIYFeedback.DIYEveningId,
        source.DIYFeedback.CustomerName,
        source.DIYFeedback.Feedback
    );
}