# Equipment Registration Process

## 1. Open the Management Form After Login

- After the user logs in, the `ManagementForm` is displayed.

## 2. Instantiate `EquipmentController` in `ManagementForm`

- `ManagementForm` creates an instance of `EquipmentController`.

## 3. Fetch Data from Memory in `ManagementForm`

- `ManagementForm` retrieves the existing equipment data from memory to display.

## 4. Handle the Add Button Click Event

- When the user clicks the **Add** button (top-left corner), the `Add` method of `EquipmentController` is called.

## 5. Process in `Add` Method


// Instantiate the EquipmentForm
EquipmentForm equipmentForm = new EquipmentForm();

// Show the EquipmentForm; the user fills in the textBoxes and dateTimePickers
equipmentForm.ShowDialog();

// Retrieve the filled Equipment instance from the EquipmentForm
Equipment equipment = equipmentForm.Equipment;

// Call the AddEquipment method in EquipmentRepo to save the equipment
EquipmentRepo.AddEquipment(equipment);


## 6. The EquipmentForm is closed, and the ManagementForm is refreshed
