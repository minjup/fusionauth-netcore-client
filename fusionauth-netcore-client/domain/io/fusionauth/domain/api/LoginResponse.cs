/*
 * Copyright (c) 2018, FusionAuth, All Rights Reserved
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *   http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND,
 * either express or implied. See the License for the specific
 * language governing permissions and limitations under the License.
 */


using io.fusionauth.domain;
using System.Collections.Generic;
using System;

namespace io.fusionauth.domain.api {

  /**
   * @author Brian Pontarelli
   */
  public class LoginResponse {

    public List<LoginPreventedResponse> actions;

    public string changePasswordId;

    public string refreshToken;

    public Dictionary<string, object> state;

    public string token;

    public string twoFactorId;

    public string twoFactorTrustId;

    public User user;

    public LoginResponse with(Action<LoginResponse> action) {
      action(this);
      return this;
    }
  }
}
