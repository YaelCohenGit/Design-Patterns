# Design Patterns Project

This project is a simulation of **Source Control activity** (similar to Git). The system allows users to manage branches, files, and folders while ensuring that all actions follow a predefined workflow. The project demonstrates advanced software design patterns to achieve modularity, scalability, and efficient behavior.

## Features

- **File State Management**:
  - Files transition through multiple states during development (e.g., draft, reviewed, approved).
  - Ensures no steps in the workflow are skipped.
  
- **History and Restoration**:
  - Maintains a history of all actions performed on a file.
  - Allows users to restore files to a previous state using the Memento pattern.

- **Review System**:
  - Automatically notifies relevant parties when a review request is made.
  - Simulates collaboration in a source control environment.

- **Composite Structure**:
  - Supports hierarchical management of branches, files, and folders.
  - Provides an intuitive way to manage complex structures in source control.

## Design Patterns Used

1. **Composite**:
   - Used to represent the hierarchical relationship between branches, files, and folders.
   - Enables uniform treatment of individual files and collections of files or folders.

2. **State**:
   - Implements the different states a file can be in (e.g., draft, reviewed, approved).
   - Ensures smooth transitions between states while maintaining workflow integrity.

3. **Observer**:
   - Notifies relevant parties when a review request is triggered.
   - Ensures real-time updates and collaboration.

4. **Memento**:
   - Records the history of actions performed on a file.
   - Provides functionality to restore a file to any previous state.

## Project Structure

- **Headers**: Definitions of classes representing branches, files, folders, and design patterns.
- **Source Files**: Implementations of the system's logic and design patterns.
- **Main Program**: Demonstrates the functionality of the system, including file state transitions, history management, and review workflows.

## Contribution

1. Fork the repository.
2. Create a new branch (`git checkout -b feature-name`).
3. Commit your changes (`git commit -am 'Add new feature'`).
4. Push to the branch (`git push origin feature-name`).
5. Create a Pull Request.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Acknowledgments

This project was developed to showcase the practical use of advanced software design patterns in simulating a real-world source control system.
