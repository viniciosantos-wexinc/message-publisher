namespace Messages.Settings;

public record Messages(
    Message AddressChangeDetected,
    Message SubscribedToReclaim,
    Message UserChangeDetected,
    Message EmployeeCreated,
    Message ElectionChanged
);