//
//  LoginViewController.swift
//  MyUniLife
//
//  Created by Tom Starling on 05/10/2017.
//  Copyright © 2017 Tom Starling. All rights reserved.
//

import UIKit
import Firebase
import FirebaseAuth

class LoginViewController: UIViewController {
    
    //----------------------UI Elements----------------------
    //Login
    @IBOutlet weak var emailAddress: UITextField!
    @IBOutlet weak var password: UITextField!
    //-------------------------------------------------------

    override func viewDidLoad() {
        super.viewDidLoad()
    }

    override func didReceiveMemoryWarning() {
        super.didReceiveMemoryWarning()
    }
    
    func errorCode(message: String) {
        let alertController = UIAlertController(title: "Error", message: message, preferredStyle: .alert)
        
        let defaultAction = UIAlertAction(title: "OK", style: .cancel, handler: nil)
        alertController.addAction(defaultAction)
        
        self.present(alertController, animated: true, completion: nil)
    }

    @IBAction func Login(_ sender: Any) {
        if self.emailAddress.text == "" || self.password.text == "" {
            let alertController = UIAlertController(title: "Error", message: "Please enter an email and password.", preferredStyle: .alert)
            
            let defaultAction = UIAlertAction(title: "OK", style: .cancel, handler: nil)
            alertController.addAction(defaultAction)
            
            self.present(alertController, animated: true, completion: nil)
            
        } else {
            Auth.auth().signIn(withEmail: self.emailAddress.text!, password: self.password.text!) { (user, error) in
                
                if error != nil {
                    if let errCode = AuthErrorCode(rawValue: error!._code) {
                        
                        switch errCode {
                        case .invalidEmail:
                            self.errorCode(message: "Invalid email address entered")
                        case .userNotFound:
                            self.errorCode(message: "An account linked to this email address was not recognised")
                        case .networkError:
                            self.errorCode(message: "Network error - please check your connection")
                        case .userDisabled:
                            self.errorCode(message: "You account has been disabled, please contact the admin")
                        case .wrongPassword:
                            self.errorCode(message: "Your email or password is wrong")
                        default:
                            self.errorCode(message: "\(String(describing: error))")
                        }
                    }
                } else {
                    if let user = Auth.auth().currentUser {
                        if !user.isEmailVerified{
                            let alertController = UIAlertController(title: "Please verify your email", message: "Sorry. Your email address has not yet been verified. Do you want us to send another verification email to \(self.emailAddress.text!)", preferredStyle: .alert)
                            
                            let alertActionOkay = UIAlertAction(title: "Yes", style: .default) {
                                (_) in
                                user.sendEmailVerification(completion: nil)
                            }
                            let alertActionCancel = UIAlertAction(title: "No", style: .default, handler: nil)
                            
                            alertController.addAction(alertActionOkay)
                            alertController.addAction(alertActionCancel)
                            self.present(alertController, animated: true, completion: nil)
                        } else {
                            let storyboard = UIStoryboard(name: "MainScreen", bundle: nil)
                            let controller = storyboard.instantiateViewController(withIdentifier: "tabController")
                            
                            let login = UserDefaults.standard
                            login.set(true, forKey: "loggedIn")
                            
                            self.present(controller, animated: true, completion: nil)
                        }
                    }
                }
            }
        }
    }
}
